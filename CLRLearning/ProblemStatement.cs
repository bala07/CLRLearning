using System.Collections.Generic;

namespace CLRLearning
{
    public class ProblemStatement
    {
        public string Description;

        public string Specification;

        public IList<SampleInput> SampleInputs;

        public IList<SampleOutput> SampleOutputs;
    }
}
