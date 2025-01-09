using System;
using System.Xml.Serialization;
namespace oopConceptsHugo
{
    public abstract class AHause
    {
        public int Rooms { get; set; }
        public string Direction { get; set; }

        public abstract void OpenDoor();
        public abstract void Clean();
    }
}
