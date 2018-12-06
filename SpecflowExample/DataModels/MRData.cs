using System.Collections.Generic;

namespace SpecflowExample.DataModels
{
    class F1
    {
        public MRData MRData { get; set; }
    }

    internal class MRData
    {
        public string Series { get; set; }
        public CircuitTable CircuitTable { get; set; }
    }

    internal class CircuitTable
    {
        public string Season { get; set; }
        public List<Circuit> Circuits { get; set; }
    }

    internal class Circuit
    {
        public string CircuitId { get; set; }
        public string CircuitName { get; set; }
    }
}
