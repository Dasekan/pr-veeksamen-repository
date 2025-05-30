using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace prøveeksamen_repository
{
   
        public class WindowsRepository
        {
            private static int _nextId = 1; // Autogenereret ID starter ved 1
            private readonly List<Windows> _windows = new();

            public WindowsRepository()
            {
                // Tilføj 5 forskellige Window objekter
                Add(new Windows { Model = "SuperA", EnergyClass = 'A', Price = 3500 });
                Add(new Windows { Model = "Flex", EnergyClass = 'C', Price = 1900 });
                Add(new Windows { Model = "Basis", EnergyClass = 'B', Price = 2700 });
                Add(new Windows { Model = "Flex stor", EnergyClass = 'A', Price = 4200 });
                Add(new Windows { Model = "GlassLite", EnergyClass = 'B', Price = 3100 });
            }

            public List<Windows> GetAll()
            {
                return new List<Windows>(_windows); // Returner en kopi for sikkerhed
            }

            public Windows? GetById(int id)
            {
                return _windows.FirstOrDefault(w => w.Id == id);
            }

            public Windows Add(Windows window)
            {
                window.Id = _nextId++;
                _windows.Add(window);
                return window;
            }

            public Windows? Delete(int id)
            {
                var window = GetById(id);
                if (window != null)
                {
                    _windows.Remove(window);
                    return window;
                }
                return null;
            }
        }
    }


