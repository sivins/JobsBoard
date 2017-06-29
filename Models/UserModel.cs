using System;
namespace reverseJobsBoard.Models
{
		public class User
		{
			public string first_name { get; set; }
            public string last_name { get; set;}
            public string email { get; set;}
			public Guid ID { get; set; } 
 
       		public string Username { get; set; } 
 
        	public string Password { get; set; }
			
		}

}
