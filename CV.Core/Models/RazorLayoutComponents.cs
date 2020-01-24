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
    }
    public class SplitSection
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Text { get; set; }
    }

    public class IHtmlElement
    {
        public string CssClass { get; set; }
    }

}
