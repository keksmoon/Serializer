using System;
using System.Collections.Generic;
using System.IO;

namespace Serializer {

    #region Types to serializable
    [Serializable]
    public class DirectoryDescription : ICloneable {
        public List<DirectoryDescription> SubFolders { get; set; }
        public List<FileDescription> Files { get; set; }
        public FileAttributes Attributes { get; set; }
        public string Name { get; set; }
        public long Volume { get; set; }
        public DateTime LastWriteTime { get; set; }
        public string Path;
        public object Clone() {
            return new DirectoryDescription { SubFolders = this.SubFolders, 
                Files = this.Files, Attributes = this.Attributes, Name = this.Name,
            Volume = this.Volume, LastWriteTime = this.LastWriteTime };
        }
        public DirectoryDescription() {
            SubFolders = new List<DirectoryDescription>();
            Files = new List<FileDescription>();
            Attributes = FileAttributes.Normal;
            Name = "Name not specified";
            Volume = 0;
            LastWriteTime = DateTime.Now;
        }

    }
    [Serializable]
    public class FileDescription {
        public int Data { get; set; }
        public FileAttributes Attributes { get; set; }
        public string Name { get; set; }
        public long Volume { get; set; }
        public DateTime LastWriteTime { get; set; }

        public FileDescription() {
            Data = 0;
            Attributes = FileAttributes.Normal;
            Name = "Name not specified";
            Volume = 0;
            LastWriteTime = DateTime.Now;
        }
    }
    #endregion
}
