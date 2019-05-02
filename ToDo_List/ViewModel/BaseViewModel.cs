using System;

namespace ToDo_List.ViewModel
{
    public class BaseViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime Datacriacao { get; set; }
    }
}