﻿namespace TimerWinForms
{
    public class User
    {
        public int Id {  get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public ICollection<Time> Times { get; set; }
    }
}
