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
                Badges = new List<Badge>() {
                    new Badge() { Text="07907 937 649", CssClass="light d-block" },
                    new Badge() { Text="peter@email.com" , CssClass="light d-block"}
                }
            };
            var profileCard = new Card()
            {
                CssClass = "text-center",
                Sections = new List<Section>() { profileSection }
            };

            var skillCard = new Card()
            {
                Sections = new List<Section>() {
                    new Section()
                    {
                        SubTitle = "Back End",
                        Badges = new List<Badge>()
                        {
                            new Badge(){ Text="C#", CssClass="primary"}
                        }
                    }
                }
            };

            sidebar.Cards.Add(profileCard);
            sidebar.Cards.Add(skillCard);

            var returnModel = new RazorLayoutView()
            {
                Sidebar = sidebar
            };
            return returnModel;
        }
    }
}
