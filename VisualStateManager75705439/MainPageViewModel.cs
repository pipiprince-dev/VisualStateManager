using System;
using System.Collections.ObjectModel;


namespace VisualStateManager75705439
{
	public class MainPageViewModel
	{
		public ObservableCollection<Item> ItemCollection { get; set; } = new ObservableCollection<Item>();

		public MainPageViewModel()
		{
			ItemCollection.Add(
				new Item
				{

					Name = "123"

				});
            ItemCollection.Add(
            new Item
            {

                Name = "123"

            });
            ItemCollection.Add(
            new Item
            {

                Name = "123"

            });
        }
	}
}

