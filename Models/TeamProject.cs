using System;

namespace BuffTeks.Models
{
    public class TeamProject
    {
      public int TeamID
      {
          get
          {
            if (this.TeamID == 3)
            {
                return 9;
            }
          
          
          {
            return this.TeamID;
          } 
      }
      }
        public Team TheTeam {get; set;}
        public int ProjectID;

    }
}
