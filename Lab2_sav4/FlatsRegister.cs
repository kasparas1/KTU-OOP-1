using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_sav4
{
    class FlatsRegister
    {
        private List<Flat> AllFlats;
        public FlatsRegister()
        {
            AllFlats = new List<Flat>();
        }
        public FlatsRegister(List<Flat> flats)
        {
            AllFlats = new List<Flat>();
            foreach (Flat flat in flats)
                Add(flat);
        }
        public void Add(Flat flat)
        {
            AllFlats.Add(flat);
        }
        public int Count()
        {
            return AllFlats.Count;
        }
        public Flat GetFlat(int index)
        {
            return AllFlats[index];
        }
        public static List<Flat> FilterByRoomNo(List<Flat> flats, int roomNo)
        {
            List<Flat> Filtered = new List<Flat>();
            foreach (Flat flat in flats)
                if (flat.RoomNo == roomNo)
                    Filtered.Add(flat);
            return Filtered;
        }
        public List<Flat> FilterByRoomNo(int roomNo)
        {
            return FilterByRoomNo(AllFlats, roomNo);
        }
        public static List<Flat> FilterByPrice(List<Flat> flats, double max)
        {
            List<Flat> Filtered = new List<Flat>();
            foreach (Flat flat in flats)
                if (flat.Price <= max)
                    Filtered.Add(flat);
            return Filtered;
        }
        public List<Flat> FilterByPrice(double max)
        {
            return FilterByPrice(AllFlats, max);
        }
        public static List<Flat> FilterByFloor(List<Flat> flats, int minFloor, int maxFloor)
        {
            List<Flat> Filtered = new List<Flat>();
            foreach (Flat flat in flats)
                if (flat.Floor >= minFloor && flat.Floor <= maxFloor)
                    Filtered.Add(flat);
            return Filtered;
        }
        public List<Flat> FilterbyFloor(int minFloor, int maxFloor)
        {
            return FilterByFloor(AllFlats, minFloor, maxFloor);
        }
    }
}
