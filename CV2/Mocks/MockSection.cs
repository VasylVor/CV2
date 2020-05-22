using CV2.Interfaces;
using CV2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CV2.Mocks
{
    public class MockSection : ISection
    {
        public IEnumerable<Section> Menu
        {
            get
            {
                return new List<Section>()
                {
                    new Section()
                    {
                        Id = 1,
                        SectionName = "test",
                        MenuName = "test",
                        ControlsValues = null,
                        Active = true
                    },
                     new Section()
                    {
                        Id = 2,
                        SectionName = "test2",
                        MenuName = "test2",
                        ControlsValues = null,
                        Active = true
                    },
                };
            }
        }
    }
}
