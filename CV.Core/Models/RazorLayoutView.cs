using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV.Core.Models
{
    public class RazorLayoutView
    {
        public Sidebar Sidebar { get; set; }


        public RazorLayoutView Seed()
        {
            var sidebar = new Sidebar();

            var profileSection = new Section()
            {

                Title = "Peter Stankowski",
                Text = "test"
            };
            var profileCard = new Card()
            {
                CssClass = "text-center",
                Sections = new List<Section>() { profileSection }
            };

            sidebar.Cards.Add(profileCard);

            var returnModel = new RazorLayoutView()
            {
                Sidebar = sidebar
            };
            return returnModel;
        }
    }
}
