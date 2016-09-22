using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItem
    {
        private string _description;
        private string _id;
        private string _pack;

        public string description
        {
            get { return _description; }
            set { _description = value; }
        }
        public string id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string pack
        {
            get { return _pack; }
            set { _pack = value; }
        }
        public override string ToString()
        {
            return this._description + " " + this._id + " " + this._pack;
        }

        public WineItem(String description, String id, String pack)
        {
            this._description = description;
            this._id = id;
            this._pack = pack;
        }
        public WineItem()
        {

        }
    }

}