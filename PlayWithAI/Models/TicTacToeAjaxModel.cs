using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlayWithAI.Models
{
    public class TicTacToeAjaxModel
    {
        // Indicates bot's new move's row
        public int Row { get; set; }

        // Indicates bot's new move's column
        public int Col { get; set; }
    }
}