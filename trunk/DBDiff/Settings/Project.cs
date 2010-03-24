using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DBDiff.Schema.SQLServer.Generates.Options;
using System.IO;
using System.Reflection;
using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace DBDiff.Settings
{
    public class Project
    {
        private static string projectFile = string.Format("{0}\\Projects.xml", Path.GetDirectoryName(Assembly.GetCallingAssembly().Location));
        public static List<Project> AllProjects { get; set; }

        #region Public Fields
        public enum ProjectType
        { 
            SQLServer = 1
        }

        public int Id { get; set; }
        public string ConnectionStringSource { get; set; }
        public string ConnectionStringDestination { get; set; }
        public ProjectType Type { get; set; }
        public string Name { get; set; }
        public bool WasLastUsed { get; set; }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        static Project()
        {
            if (File.Exists(projectFile))
                Project.Deserialize();
            else
                AllProjects = new List<Project>();
        }

        /// <summary>
        /// Add a Project to the list in the databse
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static void Add(Project item)
        {
            AllProjects.Add(item);
        }

        /// <summary>
        /// Update an existing item in the Project List
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static void Update(Project item)
        {
            Project toUpdate = AllProjects.Find(proj => proj.Id == item.Id);
            toUpdate = new Project()
            {
                ConnectionStringDestination = item.ConnectionStringDestination,
                ConnectionStringSource = item.ConnectionStringSource,
                Id = item.Id,
                Name = item.Name,
                Type = item.Type,
                WasLastUsed = item.WasLastUsed
            };
        }

        /// <summary>
        /// Delete an item from the project list
        /// </summary>
        /// <param name="Id"></param>
        public static void Delete(int Id)
        {
            Project toDelete = AllProjects.Find(proj => proj.Id == Id);
            if (toDelete != null)
                AllProjects.Remove(toDelete);

            Serialize();
        }

        /// <summary>
        /// Save an item, decide whether to insert or update.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public static void Save(Project item)
        {
            Project projectToSave = AllProjects.Find(proj => proj.Id == item.Id);

            if (projectToSave == null)
            {
                item.Id = Project.AllProjects.Count + 1;
                Add(item);
            }
            else
                Update(projectToSave);

            Serialize();
        }

        public static void SaveLastConfiguration(string ConnectionStringSource, string ConnectionStringDestination)
        {
            Project lastUsedProject = AllProjects.Find(proj => proj.ConnectionStringSource.ToLower() == ConnectionStringSource.ToLower() && proj.ConnectionStringDestination.ToLower() == ConnectionStringDestination.ToLower());
            AllProjects.ForEach(proj => proj.WasLastUsed = false);

            if (lastUsedProject == null)
            {
                lastUsedProject = new Project() 
                { 
                    ConnectionStringDestination = ConnectionStringDestination, 
                    ConnectionStringSource = ConnectionStringSource, 
                    Type = ProjectType.SQLServer, 
                    WasLastUsed = true
                };
                lastUsedProject.Id = Project.AllProjects.Count + 1;
                Add(lastUsedProject);
            }
            else
            {
                lastUsedProject.WasLastUsed = true;
                lastUsedProject.ConnectionStringSource = ConnectionStringSource;
                lastUsedProject.ConnectionStringDestination = ConnectionStringDestination;
                Update(lastUsedProject);
            }

            //Serialize the changes back down to disk
            Serialize();
        }

        public static Project GetLastConfiguration()
        {
            //Project item = null;
            return AllProjects.Find(projects => projects.WasLastUsed);
        }

        private static void Serialize()
        {
            XmlSerializer s = new XmlSerializer(typeof(List<Project>));
            using (TextWriter w = new StreamWriter(projectFile))
                s.Serialize(w, AllProjects);
        }

        private static void Deserialize()
        {
            XmlSerializer s = new XmlSerializer(typeof(List<Project>));
            using (TextReader r = new StreamReader(projectFile))
            {
                AllProjects = s.Deserialize(r) as List<Project>;
                if (AllProjects == null)
                    AllProjects = new List<Project>();
            }
        }
    }
}
