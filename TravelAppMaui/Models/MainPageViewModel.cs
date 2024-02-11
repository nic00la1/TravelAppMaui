using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace TravelAppMaui.Models
{
    public partial class MainPageViewModel : ObservableObject
    {
        public ObservableCollection<CarouselItem> CarouselItems { get; set; } = new();

        public MainPageViewModel()
        {
            CarouselItems.Add(new CarouselItem
            {
                Title = "Haleakalā National Park",
                Description = "Haleakalā National Park is a United States national park located on the island of Maui in the state of Hawaii.",
                Image = "haleakala.jpg"
            });

            CarouselItems.Add(new CarouselItem
            {
                Title = "Road to Hana",
                Description = "The Road to Hana is a long and winding road that takes you through the lush rainforest of Maui.",
                Image = "roadtohana.jpg"
            });

            CarouselItems.Add(new CarouselItem
            {
                Title = "Lahaina",
                Description = "Lahaina is a town on the western end of the island of Maui, Hawaii that abounds with restaurants, night life, and shopping.",
                Image = "lahaina.jpg"
            });

            CarouselItems.Add(new CarouselItem
            {
                Title = "Molokini",
                Description = "Molokini is a crescent-shaped, partially submerged volcanic crater which forms a small, uninhabited islet located in ʻAlalākeiki Channel between the islands of Maui and Kahoʻolawe.",
                Image = "molokini.jpg"
            });
        }

    }
}
