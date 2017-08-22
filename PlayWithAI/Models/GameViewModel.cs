using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlayWithAI.Models
{
    public class GameViewModel
    {
        private int size;

        public GameViewModel(int size)
        {
            this.size = size;
        }

        public int Size {
            get
            {
                return size;
            }
        }
    }
}