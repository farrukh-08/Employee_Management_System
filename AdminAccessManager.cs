using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace VP_Project
{
    public static class AdminAccessManager
    {
        public static List<int> AdminIds = new List<int>();
        private static string filePath = "admin_access_data.xml"; // XML file to store admin IDs

        // Load Admin IDs from the XML file
        public static void LoadAdminIds()
        {
            if (File.Exists(filePath))
            {
                try
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<int>));
                    using (FileStream fs = new FileStream(filePath, FileMode.Open))
                    {
                        AdminIds = (List<int>)serializer.Deserialize(fs) ?? new List<int>();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading admin data: {ex.Message}");
                }
            }
        }

        // Save Admin IDs to the XML file
        public static void SaveAdminIds()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<int>));
                using (FileStream fs = new FileStream(filePath, FileMode.Create))
                {
                    serializer.Serialize(fs, AdminIds);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving admin data: {ex.Message}");
            }
        }
    }
}
