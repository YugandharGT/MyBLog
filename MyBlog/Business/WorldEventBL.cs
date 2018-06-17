using MVCProj.Models;
using MVCProj.Data;
using MVCProj.Utilities;
using System.Collections.Generic;
using System.Data;


namespace MVCProj.Business
{
    public class WorldEventBL
    {
        readonly WorldEvents worldEvent;
        readonly Extension ext;

        public WorldEventBL()
        {

        }

        internal WorldEventBL(WorldEvents WorldEvent)
        {
            worldEvent = WorldEvent;
        }

        internal WorldEventBL(WorldEvents WorldEvent, Extension ext)
        {
            worldEvent = WorldEvent;
            this.ext = ext;

        }

        internal List<EventDTO> GetEvents()
        {
           DataTable dt = worldEvent.GetEventDetails();
           return this.ext.ConvertTo<EventDTO>(dt);
        }

    }
}