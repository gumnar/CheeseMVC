using CheeseMVC.Models.Cheese;
using System.Collections.Generic;

namespace CheeseMVC.ViewModels
{
    public class DeleteCheesesViewModel
    {
        public List<Cheese> Cheeses { get; set; }

        public List<int> SelectedCheeses { get; set; }

        public DeleteCheesesViewModel()
        {
            this.Cheeses = CheeseData.GetAll();
        }

        public void Delete()
        {
            if (SelectedCheeses == null)
                return;

            foreach(int cheeseId in SelectedCheeses)
            {
                CheeseData.Remove(cheeseId);
            }
        }
    }
}
