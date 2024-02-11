using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace TravelAppMaui.Models
{
    public partial class SecondPageViewModel : ObservableObject
    {
        public ObservableCollection<CollectionItem> CollectionItems { get; set; } = new();

        public SecondPageViewModel()
        {
            CollectionItems.Add(new CollectionItem
            {
                Title = "Boat Camping",
                Image = "camping_boat.jpg",
                Price = "$15",
                Place = "Lake Como, Italy."
            });
            CollectionItems.Add(new CollectionItem
            {
                Title = "Alps Trekking",
                Image = "alps.jpg",
                Price = "$20",
                Place = "Europe, Italy."
            });
        }
    }
}
