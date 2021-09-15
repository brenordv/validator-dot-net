
using Raccoon.Ninja.ValidatorDotNet.Exceptions;
using ValidatorDotNet;

namespace Raccoon.Ninja.ValidatorDotNet
{
    public static partial class Validate
    {
        public static partial class Specializations
        {
            /// <summary>
            ///     Ported from private project.
            ///     Checks if a given "affected rows" variable value is equal to one.
            /// </summary>
            /// <param name="affectedRows">number of affected rows</param>
            /// <param name="allowNoAffectedLines">If true, will not throw an error when there's no affected rows</param>
            /// <returns>true if is 'single row affected' or false otherwise</returns>

            public static bool TryIsSingleRowAffectedForId(long affectedRows, bool allowNoAffectedLines = false)
            {
                return affectedRows == 1 || (affectedRows == 0 && allowNoAffectedLines);
            }
            
            /// <summary>
            ///     Ported from private project.
            ///     Checks if a given "affected rows" variable value is equal to one.
            /// </summary>
            /// <param name="affectedRows">number of affected rows</param>
            /// <param name="id">id used on the operation that resulted the affected rows value</param>
            /// <param name="label">Label to be used in the error message</param>
            /// <param name="allowNoAffectedLines">If true, will not throw an error when there's no affected rows</param>
            /// <exception cref="NoRowsAffectedException">If no rows were affected</exception>
            /// <exception cref="UnexpectedException">If more than one row was affected. </exception>
            public static void IsSingleRowAffectedForId(long affectedRows, object id, string label,
                bool allowNoAffectedLines = false)
            {
                if (affectedRows == 0 && !allowNoAffectedLines)
                    throw new NoRowsAffectedException(string.Format(ValidationErrorMessages.NoEntryWithId, label, id));
                if (affectedRows > 1)
                    throw new UnexpectedException(string.Format(ValidationErrorMessages.MultiRowsAffectedById,
                        affectedRows, label, id));
            }
        }
    }
}