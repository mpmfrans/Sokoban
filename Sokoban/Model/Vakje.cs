using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sokoban.Model;

namespace Sokoban.Model
{
    public class Vakje
    {
        private Soort soort;
        private Dictionary<Richting, Vakje> buren = new Dictionary<Richting,Vakje>();
        private Krat krat;

        public Vakje(Soort soort)
        {
            this.soort = soort;
            buren = null;
        } 

        public bool canMoveHere(Richting r) {
            
            return false;
        }

        public bool getNeighbours(Richting r) {
            return false;
        }

        public bool hasKrat() {
            if (krat != null)
            {
                return true;
            }
            else {
                return false;
            }
        }

        public void setNeighbour(){
            
        }  
    }
}
