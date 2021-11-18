using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV.Core.Models
{
    public class Sidebar
    {
        List<Card> _cards;
        public List<Card> Cards
        {
            get
            {
                if (_cards == null)
                    _cards = new List<Card>();
                return _cards;
            }
            set
            {
                _cards = value;
            }
        }

    }

    public class Card : IHtmlElement
    {
        public string AvatarPath { get; set; }

        List<Section> _sections;
        public List<Section> Sections
        {
            get
            {
                if (_sections == null)
                    _sections = new List<Section>();
                return _sections;
            }
            set
            {
                _sections = value;
            }
        }

        List<SplitSection> _splitSections;
        public List<SplitSection> SplitSections
        {
            get
            {
                if (_splitSections == null)
                    _splitSections = new List<SplitSection>();
                return _splitSections;
            }
            set
            {
                _splitSections = value;
            }
        }
    }

    public class Section
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Text { get; set; }

        public List<Badge> Badges { get; set; }
        public BadgeList BadgeList { get; set; }
    }
    public class SplitSection
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Text { get; set; }
    }

    public class Badge : IHtmlElement
    {
        public string Text { get; set; }
        public string AsHtml()
        {
            return string.Format("<span class='p-2 m-1 badge badge-{0}'>{1}</span>", CssClass, Text);
        }
    }

    public class BadgeList : IHtmlElement
    {
        public string Text { get; set; }
        public string GroupName { get; set; }
        public string CssClass { get; set; }

        public string AsHtml()
        {
            var badges = "";
            foreach (string badge in Text.Split(','))
            {
                badges += new Badge()
                {
                    Text = badge,
                    CssClass = CssClass
                }.AsHtml();
            }

            return AddHr ? $"{badges}<hr />": badges;
        }
    }

    public class IHtmlElement
    {
        public string CssClass { get; set; }
        public bool AddHr { get; set; }

    }

}
