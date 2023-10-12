using System;

using R5T.T0132;


namespace R5T.S0107
{
    [FunctionalityMarker]
    public partial interface IScripts : IFunctionalityMarker
    {
        /// <summary>
        /// Given a member instance, get the type signature for it.
        /// </summary>
        public void Get_SignatureForMember()
        {
            /// Inputs.
            var member = Instances.ExampleMembers
               .Class_001
               ;
            var outputFilePath = Instances.FilePaths.OutputJsonFilePath;


            /// Run.
            var signature = Instances.SignatureOperator.Get_Signature(member);

            // Output to JSON.
            Instances.JsonOperator.Serialize_Synchronous(
                outputFilePath.Value,
                signature);

            Instances.NotepadPlusPlusOperator.Open(outputFilePath);
        }
    }
}
