<a name='assembly'></a>
# ValidatorDotNet

## Contents

- [BaseValidationException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-BaseValidationException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.BaseValidationException')
  - [#ctor(message)](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-BaseValidationException-#ctor-System-String- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.BaseValidationException.#ctor(System.String)')
  - [#ctor(message,e)](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-BaseValidationException-#ctor-System-String,System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.BaseValidationException.#ctor(System.String,System.Exception)')
  - [#ctor(e)](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-BaseValidationException-#ctor-System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.BaseValidationException.#ctor(System.Exception)')
  - [#ctor(info,context)](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-BaseValidationException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.BaseValidationException.#ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)')
- [Constraints](#T-Raccoon-Ninja-ValidatorDotNet-Constants-Constraints 'Raccoon.Ninja.ValidatorDotNet.Constants.Constraints')
- [DateTimeNotInUtcException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-DateTimeNotInUtcException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.DateTimeNotInUtcException')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-DateTimeNotInUtcException-#ctor-System-String- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.DateTimeNotInUtcException.#ctor(System.String)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-DateTimeNotInUtcException-#ctor-System-String,System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.DateTimeNotInUtcException.#ctor(System.String,System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-DateTimeNotInUtcException-#ctor-System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.DateTimeNotInUtcException.#ctor(System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-DateTimeNotInUtcException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.DateTimeNotInUtcException.#ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)')
- [DefaultLabels](#T-Raccoon-Ninja-ValidatorDotNet-Internationalization-DefaultLabels 'Raccoon.Ninja.ValidatorDotNet.Internationalization.DefaultLabels')
  - [Culture](#P-Raccoon-Ninja-ValidatorDotNet-Internationalization-DefaultLabels-Culture 'Raccoon.Ninja.ValidatorDotNet.Internationalization.DefaultLabels.Culture')
  - [List](#P-Raccoon-Ninja-ValidatorDotNet-Internationalization-DefaultLabels-List 'Raccoon.Ninja.ValidatorDotNet.Internationalization.DefaultLabels.List')
  - [Object](#P-Raccoon-Ninja-ValidatorDotNet-Internationalization-DefaultLabels-Object 'Raccoon.Ninja.ValidatorDotNet.Internationalization.DefaultLabels.Object')
  - [Parameter](#P-Raccoon-Ninja-ValidatorDotNet-Internationalization-DefaultLabels-Parameter 'Raccoon.Ninja.ValidatorDotNet.Internationalization.DefaultLabels.Parameter')
  - [ResourceManager](#P-Raccoon-Ninja-ValidatorDotNet-Internationalization-DefaultLabels-ResourceManager 'Raccoon.Ninja.ValidatorDotNet.Internationalization.DefaultLabels.ResourceManager')
  - [Text](#P-Raccoon-Ninja-ValidatorDotNet-Internationalization-DefaultLabels-Text 'Raccoon.Ninja.ValidatorDotNet.Internationalization.DefaultLabels.Text')
  - [UtcOffset](#P-Raccoon-Ninja-ValidatorDotNet-Internationalization-DefaultLabels-UtcOffset 'Raccoon.Ninja.ValidatorDotNet.Internationalization.DefaultLabels.UtcOffset')
- [DynamicPropertyNotFoundException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-DynamicPropertyNotFoundException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.DynamicPropertyNotFoundException')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-DynamicPropertyNotFoundException-#ctor-System-String- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.DynamicPropertyNotFoundException.#ctor(System.String)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-DynamicPropertyNotFoundException-#ctor-System-String,System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.DynamicPropertyNotFoundException.#ctor(System.String,System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-DynamicPropertyNotFoundException-#ctor-System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.DynamicPropertyNotFoundException.#ctor(System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-DynamicPropertyNotFoundException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.DynamicPropertyNotFoundException.#ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)')
- [ElementComparisonException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-ElementComparisonException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.ElementComparisonException')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-ElementComparisonException-#ctor-System-String- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.ElementComparisonException.#ctor(System.String)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-ElementComparisonException-#ctor-System-String,System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.ElementComparisonException.#ctor(System.String,System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-ElementComparisonException-#ctor-System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.ElementComparisonException.#ctor(System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-ElementComparisonException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.ElementComparisonException.#ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)')
- [EmptyListException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-EmptyListException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.EmptyListException')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-EmptyListException-#ctor-System-String- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.EmptyListException.#ctor(System.String)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-EmptyListException-#ctor-System-String,System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.EmptyListException.#ctor(System.String,System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-EmptyListException-#ctor-System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.EmptyListException.#ctor(System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-EmptyListException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.EmptyListException.#ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)')
- [InvalidEnumException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidEnumException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.InvalidEnumException')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidEnumException-#ctor-System-String- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.InvalidEnumException.#ctor(System.String)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidEnumException-#ctor-System-String,System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.InvalidEnumException.#ctor(System.String,System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidEnumException-#ctor-System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.InvalidEnumException.#ctor(System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidEnumException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.InvalidEnumException.#ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)')
- [InvalidGuidException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidGuidException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.InvalidGuidException')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidGuidException-#ctor-System-String- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.InvalidGuidException.#ctor(System.String)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidGuidException-#ctor-System-String,System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.InvalidGuidException.#ctor(System.String,System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidGuidException-#ctor-System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.InvalidGuidException.#ctor(System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidGuidException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.InvalidGuidException.#ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)')
- [InvalidIntegerException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidIntegerException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.InvalidIntegerException')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidIntegerException-#ctor-System-String- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.InvalidIntegerException.#ctor(System.String)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidIntegerException-#ctor-System-String,System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.InvalidIntegerException.#ctor(System.String,System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidIntegerException-#ctor-System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.InvalidIntegerException.#ctor(System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidIntegerException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.InvalidIntegerException.#ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)')
- [InvalidUtcOffsetException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidUtcOffsetException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.InvalidUtcOffsetException')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidUtcOffsetException-#ctor-System-String- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.InvalidUtcOffsetException.#ctor(System.String)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidUtcOffsetException-#ctor-System-String,System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.InvalidUtcOffsetException.#ctor(System.String,System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidUtcOffsetException-#ctor-System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.InvalidUtcOffsetException.#ctor(System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidUtcOffsetException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.InvalidUtcOffsetException.#ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)')
- [MinDateForDatabase](#T-Raccoon-Ninja-ValidatorDotNet-Constants-Constraints-MinDateForDatabase 'Raccoon.Ninja.ValidatorDotNet.Constants.Constraints.MinDateForDatabase')
  - [MariaDb](#F-Raccoon-Ninja-ValidatorDotNet-Constants-Constraints-MinDateForDatabase-MariaDb 'Raccoon.Ninja.ValidatorDotNet.Constants.Constraints.MinDateForDatabase.MariaDb')
  - [MySql](#F-Raccoon-Ninja-ValidatorDotNet-Constants-Constraints-MinDateForDatabase-MySql 'Raccoon.Ninja.ValidatorDotNet.Constants.Constraints.MinDateForDatabase.MySql')
  - [Oracle](#F-Raccoon-Ninja-ValidatorDotNet-Constants-Constraints-MinDateForDatabase-Oracle 'Raccoon.Ninja.ValidatorDotNet.Constants.Constraints.MinDateForDatabase.Oracle')
  - [Postgres](#F-Raccoon-Ninja-ValidatorDotNet-Constants-Constraints-MinDateForDatabase-Postgres 'Raccoon.Ninja.ValidatorDotNet.Constants.Constraints.MinDateForDatabase.Postgres')
  - [SqlServer](#F-Raccoon-Ninja-ValidatorDotNet-Constants-Constraints-MinDateForDatabase-SqlServer 'Raccoon.Ninja.ValidatorDotNet.Constants.Constraints.MinDateForDatabase.SqlServer')
  - [Sqlite](#F-Raccoon-Ninja-ValidatorDotNet-Constants-Constraints-MinDateForDatabase-Sqlite 'Raccoon.Ninja.ValidatorDotNet.Constants.Constraints.MinDateForDatabase.Sqlite')
- [NoRowsAffectedException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-NoRowsAffectedException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NoRowsAffectedException')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NoRowsAffectedException-#ctor-System-String- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NoRowsAffectedException.#ctor(System.String)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NoRowsAffectedException-#ctor-System-String,System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NoRowsAffectedException.#ctor(System.String,System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NoRowsAffectedException-#ctor-System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NoRowsAffectedException.#ctor(System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NoRowsAffectedException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NoRowsAffectedException.#ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)')
- [NotAllNumbersPositiveException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotAllNumbersPositiveException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NotAllNumbersPositiveException')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotAllNumbersPositiveException-#ctor-System-String- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NotAllNumbersPositiveException.#ctor(System.String)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotAllNumbersPositiveException-#ctor-System-String,System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NotAllNumbersPositiveException.#ctor(System.String,System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotAllNumbersPositiveException-#ctor-System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NotAllNumbersPositiveException.#ctor(System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotAllNumbersPositiveException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NotAllNumbersPositiveException.#ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)')
- [NotEqualToException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotEqualToException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NotEqualToException')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotEqualToException-#ctor-System-String- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NotEqualToException.#ctor(System.String)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotEqualToException-#ctor-System-String,System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NotEqualToException.#ctor(System.String,System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotEqualToException-#ctor-System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NotEqualToException.#ctor(System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotEqualToException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NotEqualToException.#ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)')
- [NotGreaterThanException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotGreaterThanException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NotGreaterThanException')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotGreaterThanException-#ctor-System-String- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NotGreaterThanException.#ctor(System.String)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotGreaterThanException-#ctor-System-String,System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NotGreaterThanException.#ctor(System.String,System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotGreaterThanException-#ctor-System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NotGreaterThanException.#ctor(System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotGreaterThanException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NotGreaterThanException.#ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)')
- [NotGreaterThanOrEqualToException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotGreaterThanOrEqualToException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NotGreaterThanOrEqualToException')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotGreaterThanOrEqualToException-#ctor-System-String- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NotGreaterThanOrEqualToException.#ctor(System.String)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotGreaterThanOrEqualToException-#ctor-System-String,System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NotGreaterThanOrEqualToException.#ctor(System.String,System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotGreaterThanOrEqualToException-#ctor-System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NotGreaterThanOrEqualToException.#ctor(System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotGreaterThanOrEqualToException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NotGreaterThanOrEqualToException.#ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)')
- [NotLessThanException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotLessThanException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NotLessThanException')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotLessThanException-#ctor-System-String- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NotLessThanException.#ctor(System.String)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotLessThanException-#ctor-System-String,System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NotLessThanException.#ctor(System.String,System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotLessThanException-#ctor-System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NotLessThanException.#ctor(System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotLessThanException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NotLessThanException.#ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)')
- [NotLessThanOrEqualToException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotLessThanOrEqualToException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NotLessThanOrEqualToException')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotLessThanOrEqualToException-#ctor-System-String- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NotLessThanOrEqualToException.#ctor(System.String)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotLessThanOrEqualToException-#ctor-System-String,System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NotLessThanOrEqualToException.#ctor(System.String,System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotLessThanOrEqualToException-#ctor-System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NotLessThanOrEqualToException.#ctor(System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotLessThanOrEqualToException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NotLessThanOrEqualToException.#ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)')
- [NullRequiredValueException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-NullRequiredValueException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NullRequiredValueException')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NullRequiredValueException-#ctor-System-String- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NullRequiredValueException.#ctor(System.String)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NullRequiredValueException-#ctor-System-String,System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NullRequiredValueException.#ctor(System.String,System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NullRequiredValueException-#ctor-System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NullRequiredValueException.#ctor(System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NullRequiredValueException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NullRequiredValueException.#ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)')
- [NumberException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-NumberException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NumberException')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NumberException-#ctor-System-String- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NumberException.#ctor(System.String)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NumberException-#ctor-System-String,System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NumberException.#ctor(System.String,System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NumberException-#ctor-System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NumberException.#ctor(System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NumberException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NumberException.#ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)')
- [Specializations](#T-Raccoon-Ninja-ValidatorDotNet-Validate-Specializations 'Raccoon.Ninja.ValidatorDotNet.Validate.Specializations')
  - [IsSingleRowAffectedForId(affectedRows,id,label,allowNoAffectedLines)](#M-Raccoon-Ninja-ValidatorDotNet-Validate-Specializations-IsSingleRowAffectedForId-System-Int64,System-Object,System-String,System-Boolean- 'Raccoon.Ninja.ValidatorDotNet.Validate.Specializations.IsSingleRowAffectedForId(System.Int64,System.Object,System.String,System.Boolean)')
  - [TryIsSingleRowAffectedForId(affectedRows,allowNoAffectedLines)](#M-Raccoon-Ninja-ValidatorDotNet-Validate-Specializations-TryIsSingleRowAffectedForId-System-Int64,System-Boolean- 'Raccoon.Ninja.ValidatorDotNet.Validate.Specializations.TryIsSingleRowAffectedForId(System.Int64,System.Boolean)')
- [TextNullOrEmptyException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-TextNullOrEmptyException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.TextNullOrEmptyException')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-TextNullOrEmptyException-#ctor-System-String- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.TextNullOrEmptyException.#ctor(System.String)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-TextNullOrEmptyException-#ctor-System-String,System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.TextNullOrEmptyException.#ctor(System.String,System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-TextNullOrEmptyException-#ctor-System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.TextNullOrEmptyException.#ctor(System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-TextNullOrEmptyException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.TextNullOrEmptyException.#ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)')
- [TextTooBigException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-TextTooBigException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.TextTooBigException')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-TextTooBigException-#ctor-System-String- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.TextTooBigException.#ctor(System.String)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-TextTooBigException-#ctor-System-String,System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.TextTooBigException.#ctor(System.String,System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-TextTooBigException-#ctor-System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.TextTooBigException.#ctor(System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-TextTooBigException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.TextTooBigException.#ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)')
- [TypingException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-TypingException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.TypingException')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-TypingException-#ctor-System-String- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.TypingException.#ctor(System.String)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-TypingException-#ctor-System-String,System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.TypingException.#ctor(System.String,System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-TypingException-#ctor-System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.TypingException.#ctor(System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-TypingException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.TypingException.#ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)')
- [UnexpectedException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-UnexpectedException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.UnexpectedException')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-UnexpectedException-#ctor-System-String- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.UnexpectedException.#ctor(System.String)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-UnexpectedException-#ctor-System-String,System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.UnexpectedException.#ctor(System.String,System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-UnexpectedException-#ctor-System-Exception- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.UnexpectedException.#ctor(System.Exception)')
  - [#ctor()](#M-Raccoon-Ninja-ValidatorDotNet-Exceptions-UnexpectedException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext- 'Raccoon.Ninja.ValidatorDotNet.Exceptions.UnexpectedException.#ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)')
- [Utc](#T-Raccoon-Ninja-ValidatorDotNet-Constants-Constraints-Utc 'Raccoon.Ninja.ValidatorDotNet.Constants.Constraints.Utc')
  - [MaxValue](#F-Raccoon-Ninja-ValidatorDotNet-Constants-Constraints-Utc-MaxValue 'Raccoon.Ninja.ValidatorDotNet.Constants.Constraints.Utc.MaxValue')
  - [MinValue](#F-Raccoon-Ninja-ValidatorDotNet-Constants-Constraints-Utc-MinValue 'Raccoon.Ninja.ValidatorDotNet.Constants.Constraints.Utc.MinValue')
- [Validate](#T-Raccoon-Ninja-ValidatorDotNet-Validate 'Raccoon.Ninja.ValidatorDotNet.Validate')
  - [AllEnumValid\`\`1(list,label)](#M-Raccoon-Ninja-ValidatorDotNet-Validate-AllEnumValid``1-System-Collections-Generic-ICollection{``0},System-String- 'Raccoon.Ninja.ValidatorDotNet.Validate.AllEnumValid``1(System.Collections.Generic.ICollection{``0},System.String)')
  - [AllPositiveElements\`\`1(list,label)](#M-Raccoon-Ninja-ValidatorDotNet-Validate-AllPositiveElements``1-System-Collections-Generic-ICollection{``0},System-String- 'Raccoon.Ninja.ValidatorDotNet.Validate.AllPositiveElements``1(System.Collections.Generic.ICollection{``0},System.String)')
  - [CanBeInt(text)](#M-Raccoon-Ninja-ValidatorDotNet-Validate-CanBeInt-System-String- 'Raccoon.Ninja.ValidatorDotNet.Validate.CanBeInt(System.String)')
  - [DynamicHasProperty(obj,propertyName,label)](#M-Raccoon-Ninja-ValidatorDotNet-Validate-DynamicHasProperty-System-Object,System-String,System-String- 'Raccoon.Ninja.ValidatorDotNet.Validate.DynamicHasProperty(System.Object,System.String,System.String)')
  - [HasElements\`\`1(list,label)](#M-Raccoon-Ninja-ValidatorDotNet-Validate-HasElements``1-System-Collections-Generic-ICollection{``0},System-String- 'Raccoon.Ninja.ValidatorDotNet.Validate.HasElements``1(System.Collections.Generic.ICollection{``0},System.String)')
  - [IsDateTimeAfterMin(dt,label,minDate)](#M-Raccoon-Ninja-ValidatorDotNet-Validate-IsDateTimeAfterMin-System-DateTime,System-String,System-Nullable{System-DateTime}- 'Raccoon.Ninja.ValidatorDotNet.Validate.IsDateTimeAfterMin(System.DateTime,System.String,System.Nullable{System.DateTime})')
  - [IsDateTimeUtc(dt,label)](#M-Raccoon-Ninja-ValidatorDotNet-Validate-IsDateTimeUtc-System-DateTime,System-String- 'Raccoon.Ninja.ValidatorDotNet.Validate.IsDateTimeUtc(System.DateTime,System.String)')
  - [IsEnumValid\`\`1(enumObj,label)](#M-Raccoon-Ninja-ValidatorDotNet-Validate-IsEnumValid``1-``0,System-String- 'Raccoon.Ninja.ValidatorDotNet.Validate.IsEnumValid``1(``0,System.String)')
  - [IsEqualTo\`\`1(a,b,label)](#M-Raccoon-Ninja-ValidatorDotNet-Validate-IsEqualTo``1-``0,``0,System-String- 'Raccoon.Ninja.ValidatorDotNet.Validate.IsEqualTo``1(``0,``0,System.String)')
  - [IsGreaterThanOrEqualTo\`\`1(a,b,label)](#M-Raccoon-Ninja-ValidatorDotNet-Validate-IsGreaterThanOrEqualTo``1-``0,``0,System-String- 'Raccoon.Ninja.ValidatorDotNet.Validate.IsGreaterThanOrEqualTo``1(``0,``0,System.String)')
  - [IsGreaterThan\`\`1(a,b,label)](#M-Raccoon-Ninja-ValidatorDotNet-Validate-IsGreaterThan``1-``0,``0,System-String- 'Raccoon.Ninja.ValidatorDotNet.Validate.IsGreaterThan``1(``0,``0,System.String)')
  - [IsGuidValid(guid,label)](#M-Raccoon-Ninja-ValidatorDotNet-Validate-IsGuidValid-System-String,System-String- 'Raccoon.Ninja.ValidatorDotNet.Validate.IsGuidValid(System.String,System.String)')
  - [IsLessThanOrEqualTo\`\`1(a,b,label)](#M-Raccoon-Ninja-ValidatorDotNet-Validate-IsLessThanOrEqualTo``1-``0,``0,System-String- 'Raccoon.Ninja.ValidatorDotNet.Validate.IsLessThanOrEqualTo``1(``0,``0,System.String)')
  - [IsLessThan\`\`1(a,b,label)](#M-Raccoon-Ninja-ValidatorDotNet-Validate-IsLessThan``1-``0,``0,System-String- 'Raccoon.Ninja.ValidatorDotNet.Validate.IsLessThan``1(``0,``0,System.String)')
  - [IsNotNull(obj,label)](#M-Raccoon-Ninja-ValidatorDotNet-Validate-IsNotNull-System-Object,System-String- 'Raccoon.Ninja.ValidatorDotNet.Validate.IsNotNull(System.Object,System.String)')
  - [IsTextNotNull(text,label)](#M-Raccoon-Ninja-ValidatorDotNet-Validate-IsTextNotNull-System-String,System-String- 'Raccoon.Ninja.ValidatorDotNet.Validate.IsTextNotNull(System.String,System.String)')
  - [IsTextWithinCharLimit(text,maxChars,label)](#M-Raccoon-Ninja-ValidatorDotNet-Validate-IsTextWithinCharLimit-System-String,System-Int32,System-String- 'Raccoon.Ninja.ValidatorDotNet.Validate.IsTextWithinCharLimit(System.String,System.Int32,System.String)')
  - [IsUtcOffsetValid(utcOffset,label)](#M-Raccoon-Ninja-ValidatorDotNet-Validate-IsUtcOffsetValid-System-Int32,System-String- 'Raccoon.Ninja.ValidatorDotNet.Validate.IsUtcOffsetValid(System.Int32,System.String)')
  - [TryAllPositiveElements\`\`1(list)](#M-Raccoon-Ninja-ValidatorDotNet-Validate-TryAllPositiveElements``1-System-Collections-Generic-ICollection{``0}- 'Raccoon.Ninja.ValidatorDotNet.Validate.TryAllPositiveElements``1(System.Collections.Generic.ICollection{``0})')
  - [TryCanBeInt(text)](#M-Raccoon-Ninja-ValidatorDotNet-Validate-TryCanBeInt-System-String- 'Raccoon.Ninja.ValidatorDotNet.Validate.TryCanBeInt(System.String)')
  - [TryDynamicHasProperty(obj,propertyName)](#M-Raccoon-Ninja-ValidatorDotNet-Validate-TryDynamicHasProperty-System-Object,System-String- 'Raccoon.Ninja.ValidatorDotNet.Validate.TryDynamicHasProperty(System.Object,System.String)')
  - [TryHasElements\`\`1(list)](#M-Raccoon-Ninja-ValidatorDotNet-Validate-TryHasElements``1-System-Collections-Generic-ICollection{``0}- 'Raccoon.Ninja.ValidatorDotNet.Validate.TryHasElements``1(System.Collections.Generic.ICollection{``0})')
  - [TryIsDateTimeAfterMin(dt,minDate)](#M-Raccoon-Ninja-ValidatorDotNet-Validate-TryIsDateTimeAfterMin-System-DateTime,System-Nullable{System-DateTime}- 'Raccoon.Ninja.ValidatorDotNet.Validate.TryIsDateTimeAfterMin(System.DateTime,System.Nullable{System.DateTime})')
  - [TryIsDateTimeUtc(dt)](#M-Raccoon-Ninja-ValidatorDotNet-Validate-TryIsDateTimeUtc-System-DateTime- 'Raccoon.Ninja.ValidatorDotNet.Validate.TryIsDateTimeUtc(System.DateTime)')
  - [TryIsEnumValid\`\`1(enumObj)](#M-Raccoon-Ninja-ValidatorDotNet-Validate-TryIsEnumValid``1-``0- 'Raccoon.Ninja.ValidatorDotNet.Validate.TryIsEnumValid``1(``0)')
  - [TryIsEqualTo\`\`1(a,b)](#M-Raccoon-Ninja-ValidatorDotNet-Validate-TryIsEqualTo``1-``0,``0- 'Raccoon.Ninja.ValidatorDotNet.Validate.TryIsEqualTo``1(``0,``0)')
  - [TryIsGreaterThanOrEqualTo\`\`1(a,b)](#M-Raccoon-Ninja-ValidatorDotNet-Validate-TryIsGreaterThanOrEqualTo``1-``0,``0- 'Raccoon.Ninja.ValidatorDotNet.Validate.TryIsGreaterThanOrEqualTo``1(``0,``0)')
  - [TryIsGreaterThan\`\`1(a,b)](#M-Raccoon-Ninja-ValidatorDotNet-Validate-TryIsGreaterThan``1-``0,``0- 'Raccoon.Ninja.ValidatorDotNet.Validate.TryIsGreaterThan``1(``0,``0)')
  - [TryIsLessThanOrEqualTo\`\`1(a,b)](#M-Raccoon-Ninja-ValidatorDotNet-Validate-TryIsLessThanOrEqualTo``1-``0,``0- 'Raccoon.Ninja.ValidatorDotNet.Validate.TryIsLessThanOrEqualTo``1(``0,``0)')
  - [TryIsLessThan\`\`1(a,b)](#M-Raccoon-Ninja-ValidatorDotNet-Validate-TryIsLessThan``1-``0,``0- 'Raccoon.Ninja.ValidatorDotNet.Validate.TryIsLessThan``1(``0,``0)')
  - [TryIsNull(obj)](#M-Raccoon-Ninja-ValidatorDotNet-Validate-TryIsNull-System-Object- 'Raccoon.Ninja.ValidatorDotNet.Validate.TryIsNull(System.Object)')
  - [TryIsTextNull(text)](#M-Raccoon-Ninja-ValidatorDotNet-Validate-TryIsTextNull-System-String- 'Raccoon.Ninja.ValidatorDotNet.Validate.TryIsTextNull(System.String)')
  - [TryIsTextWithinCharLimit(text,maxChars)](#M-Raccoon-Ninja-ValidatorDotNet-Validate-TryIsTextWithinCharLimit-System-String,System-Int32- 'Raccoon.Ninja.ValidatorDotNet.Validate.TryIsTextWithinCharLimit(System.String,System.Int32)')
  - [TryIsValidGuid(guid)](#M-Raccoon-Ninja-ValidatorDotNet-Validate-TryIsValidGuid-System-String- 'Raccoon.Ninja.ValidatorDotNet.Validate.TryIsValidGuid(System.String)')
  - [TryIsValidUtcOffset(utcOffset)](#M-Raccoon-Ninja-ValidatorDotNet-Validate-TryIsValidUtcOffset-System-Int32- 'Raccoon.Ninja.ValidatorDotNet.Validate.TryIsValidUtcOffset(System.Int32)')
- [ValidationErrorMessages](#T-ValidatorDotNet-ValidationErrorMessages 'ValidatorDotNet.ValidationErrorMessages')
  - [Culture](#P-ValidatorDotNet-ValidationErrorMessages-Culture 'ValidatorDotNet.ValidationErrorMessages.Culture')
  - [DateTimeNotInUTC](#P-ValidatorDotNet-ValidationErrorMessages-DateTimeNotInUTC 'ValidatorDotNet.ValidationErrorMessages.DateTimeNotInUTC')
  - [DynamicPropMissing](#P-ValidatorDotNet-ValidationErrorMessages-DynamicPropMissing 'ValidatorDotNet.ValidationErrorMessages.DynamicPropMissing')
  - [EmptyList](#P-ValidatorDotNet-ValidationErrorMessages-EmptyList 'ValidatorDotNet.ValidationErrorMessages.EmptyList')
  - [InvalidEnumList](#P-ValidatorDotNet-ValidationErrorMessages-InvalidEnumList 'ValidatorDotNet.ValidationErrorMessages.InvalidEnumList')
  - [InvalidEnumValue](#P-ValidatorDotNet-ValidationErrorMessages-InvalidEnumValue 'ValidatorDotNet.ValidationErrorMessages.InvalidEnumValue')
  - [InvalidGuid](#P-ValidatorDotNet-ValidationErrorMessages-InvalidGuid 'ValidatorDotNet.ValidationErrorMessages.InvalidGuid')
  - [InvalidUtcValue](#P-ValidatorDotNet-ValidationErrorMessages-InvalidUtcValue 'ValidatorDotNet.ValidationErrorMessages.InvalidUtcValue')
  - [MultiRowsAffectedById](#P-ValidatorDotNet-ValidationErrorMessages-MultiRowsAffectedById 'ValidatorDotNet.ValidationErrorMessages.MultiRowsAffectedById')
  - [NoEntryWithId](#P-ValidatorDotNet-ValidationErrorMessages-NoEntryWithId 'ValidatorDotNet.ValidationErrorMessages.NoEntryWithId')
  - [NotAllNumbersArePositive](#P-ValidatorDotNet-ValidationErrorMessages-NotAllNumbersArePositive 'ValidatorDotNet.ValidationErrorMessages.NotAllNumbersArePositive')
  - [NotEqualTo](#P-ValidatorDotNet-ValidationErrorMessages-NotEqualTo 'ValidatorDotNet.ValidationErrorMessages.NotEqualTo')
  - [NotGreaterThan](#P-ValidatorDotNet-ValidationErrorMessages-NotGreaterThan 'ValidatorDotNet.ValidationErrorMessages.NotGreaterThan')
  - [NotGreaterThanOrEqualTo](#P-ValidatorDotNet-ValidationErrorMessages-NotGreaterThanOrEqualTo 'ValidatorDotNet.ValidationErrorMessages.NotGreaterThanOrEqualTo')
  - [NotLessThan](#P-ValidatorDotNet-ValidationErrorMessages-NotLessThan 'ValidatorDotNet.ValidationErrorMessages.NotLessThan')
  - [NotLessThanOrEqualTo](#P-ValidatorDotNet-ValidationErrorMessages-NotLessThanOrEqualTo 'ValidatorDotNet.ValidationErrorMessages.NotLessThanOrEqualTo')
  - [NullRequiredValue](#P-ValidatorDotNet-ValidationErrorMessages-NullRequiredValue 'ValidatorDotNet.ValidationErrorMessages.NullRequiredValue')
  - [ResourceManager](#P-ValidatorDotNet-ValidationErrorMessages-ResourceManager 'ValidatorDotNet.ValidationErrorMessages.ResourceManager')
  - [StringIsNotANumber](#P-ValidatorDotNet-ValidationErrorMessages-StringIsNotANumber 'ValidatorDotNet.ValidationErrorMessages.StringIsNotANumber')
  - [TextSizeExceededMaxChars](#P-ValidatorDotNet-ValidationErrorMessages-TextSizeExceededMaxChars 'ValidatorDotNet.ValidationErrorMessages.TextSizeExceededMaxChars')
- [ValueTypeExtensions](#T-Raccoon-Ninja-ValidatorDotNet-ExtensionMethods-ValueTypeExtensions 'Raccoon.Ninja.ValidatorDotNet.ExtensionMethods.ValueTypeExtensions')
  - [IsNumeric(value)](#M-Raccoon-Ninja-ValidatorDotNet-ExtensionMethods-ValueTypeExtensions-IsNumeric-System-ValueType- 'Raccoon.Ninja.ValidatorDotNet.ExtensionMethods.ValueTypeExtensions.IsNumeric(System.ValueType)')

<a name='T-Raccoon-Ninja-ValidatorDotNet-Exceptions-BaseValidationException'></a>
## BaseValidationException `type`

##### Namespace

Raccoon.Ninja.ValidatorDotNet.Exceptions

##### Summary

Base Exception for all validations in this project.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-BaseValidationException-#ctor-System-String-'></a>
### #ctor(message) `constructor`

##### Summary

Constructor that receives only the error message.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | error message |

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-BaseValidationException-#ctor-System-String,System-Exception-'></a>
### #ctor(message,e) `constructor`

##### Summary

Constructor that receives the error message and an inner exception.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | error message |
| e | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | inner exception |

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-BaseValidationException-#ctor-System-Exception-'></a>
### #ctor(e) `constructor`

##### Summary

Constructor that receives only an inner exception.
    In this case, the error message will be the same as the inner exception.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| e | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | inner exception |

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-BaseValidationException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext-'></a>
### #ctor(info,context) `constructor`

##### Summary

Serialization Constructor.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| info | [System.Runtime.Serialization.SerializationInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.Serialization.SerializationInfo 'System.Runtime.Serialization.SerializationInfo') | Serialization Info |
| context | [System.Runtime.Serialization.StreamingContext](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Runtime.Serialization.StreamingContext 'System.Runtime.Serialization.StreamingContext') | Serialization Context |

<a name='T-Raccoon-Ninja-ValidatorDotNet-Constants-Constraints'></a>
## Constraints `type`

##### Namespace

Raccoon.Ninja.ValidatorDotNet.Constants

##### Summary

Constants used to restrict values of a variable.

<a name='T-Raccoon-Ninja-ValidatorDotNet-Exceptions-DateTimeNotInUtcException'></a>
## DateTimeNotInUtcException `type`

##### Namespace

Raccoon.Ninja.ValidatorDotNet.Exceptions

##### Summary

Exception used in DateTime validations

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-DateTimeNotInUtcException-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-DateTimeNotInUtcException-#ctor-System-String,System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-DateTimeNotInUtcException-#ctor-System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-DateTimeNotInUtcException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='T-Raccoon-Ninja-ValidatorDotNet-Internationalization-DefaultLabels'></a>
## DefaultLabels `type`

##### Namespace

Raccoon.Ninja.ValidatorDotNet.Internationalization

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-Raccoon-Ninja-ValidatorDotNet-Internationalization-DefaultLabels-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-Raccoon-Ninja-ValidatorDotNet-Internationalization-DefaultLabels-List'></a>
### List `property`

##### Summary

Looks up a localized string similar to list.

<a name='P-Raccoon-Ninja-ValidatorDotNet-Internationalization-DefaultLabels-Object'></a>
### Object `property`

##### Summary

Looks up a localized string similar to object.

<a name='P-Raccoon-Ninja-ValidatorDotNet-Internationalization-DefaultLabels-Parameter'></a>
### Parameter `property`

##### Summary

Looks up a localized string similar to parameter.

<a name='P-Raccoon-Ninja-ValidatorDotNet-Internationalization-DefaultLabels-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='P-Raccoon-Ninja-ValidatorDotNet-Internationalization-DefaultLabels-Text'></a>
### Text `property`

##### Summary

Looks up a localized string similar to text.

<a name='P-Raccoon-Ninja-ValidatorDotNet-Internationalization-DefaultLabels-UtcOffset'></a>
### UtcOffset `property`

##### Summary

Looks up a localized string similar to utcoffset.

<a name='T-Raccoon-Ninja-ValidatorDotNet-Exceptions-DynamicPropertyNotFoundException'></a>
## DynamicPropertyNotFoundException `type`

##### Namespace

Raccoon.Ninja.ValidatorDotNet.Exceptions

##### Summary

Exception used while validating dynamic objects.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-DynamicPropertyNotFoundException-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-DynamicPropertyNotFoundException-#ctor-System-String,System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-DynamicPropertyNotFoundException-#ctor-System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-DynamicPropertyNotFoundException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='T-Raccoon-Ninja-ValidatorDotNet-Exceptions-ElementComparisonException'></a>
## ElementComparisonException `type`

##### Namespace

Raccoon.Ninja.ValidatorDotNet.Exceptions

##### Summary

Exception used while validating by comparison.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-ElementComparisonException-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-ElementComparisonException-#ctor-System-String,System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-ElementComparisonException-#ctor-System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-ElementComparisonException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='T-Raccoon-Ninja-ValidatorDotNet-Exceptions-EmptyListException'></a>
## EmptyListException `type`

##### Namespace

Raccoon.Ninja.ValidatorDotNet.Exceptions

##### Summary

Thrown when a given list is empty (and should not be).

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-EmptyListException-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-EmptyListException-#ctor-System-String,System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-EmptyListException-#ctor-System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-EmptyListException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='T-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidEnumException'></a>
## InvalidEnumException `type`

##### Namespace

Raccoon.Ninja.ValidatorDotNet.Exceptions

##### Summary

Thrown when a given value is not a valid enum of type T.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidEnumException-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidEnumException-#ctor-System-String,System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidEnumException-#ctor-System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidEnumException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='T-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidGuidException'></a>
## InvalidGuidException `type`

##### Namespace

Raccoon.Ninja.ValidatorDotNet.Exceptions

##### Summary

Thrown when a given Guid is not valid (or empty).

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidGuidException-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidGuidException-#ctor-System-String,System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidGuidException-#ctor-System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidGuidException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='T-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidIntegerException'></a>
## InvalidIntegerException `type`

##### Namespace

Raccoon.Ninja.ValidatorDotNet.Exceptions

##### Summary

When the variable value is not a valid int.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidIntegerException-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidIntegerException-#ctor-System-String,System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidIntegerException-#ctor-System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidIntegerException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='T-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidUtcOffsetException'></a>
## InvalidUtcOffsetException `type`

##### Namespace

Raccoon.Ninja.ValidatorDotNet.Exceptions

##### Summary

Thrown when an UTC offset value is not valid.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidUtcOffsetException-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidUtcOffsetException-#ctor-System-String,System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidUtcOffsetException-#ctor-System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidUtcOffsetException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='T-Raccoon-Ninja-ValidatorDotNet-Constants-Constraints-MinDateForDatabase'></a>
## MinDateForDatabase `type`

##### Namespace

Raccoon.Ninja.ValidatorDotNet.Constants.Constraints

##### Summary

Minimum acceptable value for DateTime variables, when using a database.

<a name='F-Raccoon-Ninja-ValidatorDotNet-Constants-Constraints-MinDateForDatabase-MariaDb'></a>
### MariaDb `constants`

##### Summary

Minimum timestamp for MariaDb

<a name='F-Raccoon-Ninja-ValidatorDotNet-Constants-Constraints-MinDateForDatabase-MySql'></a>
### MySql `constants`

##### Summary

Minimum timestamp for MySql

<a name='F-Raccoon-Ninja-ValidatorDotNet-Constants-Constraints-MinDateForDatabase-Oracle'></a>
### Oracle `constants`

##### Summary

Minimum timestamp for Oracle

<a name='F-Raccoon-Ninja-ValidatorDotNet-Constants-Constraints-MinDateForDatabase-Postgres'></a>
### Postgres `constants`

##### Summary

Minimum timestamp for Postgres
    Actually, Postgres can handle timestamps as lower as 4713 BC, but C# can't, so...

<a name='F-Raccoon-Ninja-ValidatorDotNet-Constants-Constraints-MinDateForDatabase-SqlServer'></a>
### SqlServer `constants`

##### Summary

Minimum timestamp for Sql Server

<a name='F-Raccoon-Ninja-ValidatorDotNet-Constants-Constraints-MinDateForDatabase-Sqlite'></a>
### Sqlite `constants`

##### Summary

Minimum timestamp for Sqlite

<a name='T-Raccoon-Ninja-ValidatorDotNet-Exceptions-NoRowsAffectedException'></a>
## NoRowsAffectedException `type`

##### Namespace

Raccoon.Ninja.ValidatorDotNet.Exceptions

##### Summary

Thrown when the the value for "affected rows" variable is igual to zero.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NoRowsAffectedException-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NoRowsAffectedException-#ctor-System-String,System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NoRowsAffectedException-#ctor-System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NoRowsAffectedException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='T-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotAllNumbersPositiveException'></a>
## NotAllNumbersPositiveException `type`

##### Namespace

Raccoon.Ninja.ValidatorDotNet.Exceptions

##### Summary

Thrown when any non-positive number is detected inside a list.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotAllNumbersPositiveException-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotAllNumbersPositiveException-#ctor-System-String,System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotAllNumbersPositiveException-#ctor-System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotAllNumbersPositiveException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='T-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotEqualToException'></a>
## NotEqualToException `type`

##### Namespace

Raccoon.Ninja.ValidatorDotNet.Exceptions

##### Summary

Thrown when A is not igual to B.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotEqualToException-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotEqualToException-#ctor-System-String,System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotEqualToException-#ctor-System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotEqualToException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='T-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotGreaterThanException'></a>
## NotGreaterThanException `type`

##### Namespace

Raccoon.Ninja.ValidatorDotNet.Exceptions

##### Summary

Thrown when A is not greater than B.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotGreaterThanException-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotGreaterThanException-#ctor-System-String,System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotGreaterThanException-#ctor-System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotGreaterThanException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='T-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotGreaterThanOrEqualToException'></a>
## NotGreaterThanOrEqualToException `type`

##### Namespace

Raccoon.Ninja.ValidatorDotNet.Exceptions

##### Summary

Thrown when A is not greater than or equal to B.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotGreaterThanOrEqualToException-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotGreaterThanOrEqualToException-#ctor-System-String,System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotGreaterThanOrEqualToException-#ctor-System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotGreaterThanOrEqualToException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='T-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotLessThanException'></a>
## NotLessThanException `type`

##### Namespace

Raccoon.Ninja.ValidatorDotNet.Exceptions

##### Summary

Thrown when A is not less than B

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotLessThanException-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotLessThanException-#ctor-System-String,System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotLessThanException-#ctor-System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotLessThanException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='T-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotLessThanOrEqualToException'></a>
## NotLessThanOrEqualToException `type`

##### Namespace

Raccoon.Ninja.ValidatorDotNet.Exceptions

##### Summary

Thrown when A is not less than or equal to B.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotLessThanOrEqualToException-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotLessThanOrEqualToException-#ctor-System-String,System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotLessThanOrEqualToException-#ctor-System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotLessThanOrEqualToException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='T-Raccoon-Ninja-ValidatorDotNet-Exceptions-NullRequiredValueException'></a>
## NullRequiredValueException `type`

##### Namespace

Raccoon.Ninja.ValidatorDotNet.Exceptions

##### Summary

Thrown when a given variable is null.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NullRequiredValueException-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NullRequiredValueException-#ctor-System-String,System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NullRequiredValueException-#ctor-System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NullRequiredValueException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='T-Raccoon-Ninja-ValidatorDotNet-Exceptions-NumberException'></a>
## NumberException `type`

##### Namespace

Raccoon.Ninja.ValidatorDotNet.Exceptions

##### Summary

Thrown when a validation involving numbers fail.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NumberException-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NumberException-#ctor-System-String,System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NumberException-#ctor-System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-NumberException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='T-Raccoon-Ninja-ValidatorDotNet-Validate-Specializations'></a>
## Specializations `type`

##### Namespace

Raccoon.Ninja.ValidatorDotNet.Validate

##### Summary

Specialized validations are "bundled up" methods that will provide context specific validations.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Validate-Specializations-IsSingleRowAffectedForId-System-Int64,System-Object,System-String,System-Boolean-'></a>
### IsSingleRowAffectedForId(affectedRows,id,label,allowNoAffectedLines) `method`

##### Summary

Ported from private project.
    Checks if a given "affected rows" variable value is equal to one.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| affectedRows | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | number of affected rows |
| id | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | id used on the operation that resulted the affected rows value |
| label | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Label to be used in the error message |
| allowNoAffectedLines | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, will not throw an error when there's no affected rows |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Raccoon.Ninja.ValidatorDotNet.Exceptions.NoRowsAffectedException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-NoRowsAffectedException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NoRowsAffectedException') | If no rows were affected |
| [Raccoon.Ninja.ValidatorDotNet.Exceptions.UnexpectedException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-UnexpectedException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.UnexpectedException') | If more than one row was affected. |

<a name='M-Raccoon-Ninja-ValidatorDotNet-Validate-Specializations-TryIsSingleRowAffectedForId-System-Int64,System-Boolean-'></a>
### TryIsSingleRowAffectedForId(affectedRows,allowNoAffectedLines) `method`

##### Summary

Ported from private project.
    Checks if a given "affected rows" variable value is equal to one.

##### Returns

true if is 'single row affected' or false otherwise

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| affectedRows | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | number of affected rows |
| allowNoAffectedLines | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, will not throw an error when there's no affected rows |

<a name='T-Raccoon-Ninja-ValidatorDotNet-Exceptions-TextNullOrEmptyException'></a>
## TextNullOrEmptyException `type`

##### Namespace

Raccoon.Ninja.ValidatorDotNet.Exceptions

##### Summary

When a text is null or empty.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-TextNullOrEmptyException-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-TextNullOrEmptyException-#ctor-System-String,System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-TextNullOrEmptyException-#ctor-System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-TextNullOrEmptyException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='T-Raccoon-Ninja-ValidatorDotNet-Exceptions-TextTooBigException'></a>
## TextTooBigException `type`

##### Namespace

Raccoon.Ninja.ValidatorDotNet.Exceptions

##### Summary

Thrown when a string exceeds the maximum allowed size.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-TextTooBigException-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-TextTooBigException-#ctor-System-String,System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-TextTooBigException-#ctor-System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-TextTooBigException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='T-Raccoon-Ninja-ValidatorDotNet-Exceptions-TypingException'></a>
## TypingException `type`

##### Namespace

Raccoon.Ninja.ValidatorDotNet.Exceptions

##### Summary

Exception related to type-checking validations.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-TypingException-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-TypingException-#ctor-System-String,System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-TypingException-#ctor-System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-TypingException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='T-Raccoon-Ninja-ValidatorDotNet-Exceptions-UnexpectedException'></a>
## UnexpectedException `type`

##### Namespace

Raccoon.Ninja.ValidatorDotNet.Exceptions

##### Summary

A really bad exception.
    Initially used when "affected rows" variable is greater than 1 (used mainly on deletes and updates that should involve only 1 row in the database)

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-UnexpectedException-#ctor-System-String-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-UnexpectedException-#ctor-System-String,System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-UnexpectedException-#ctor-System-Exception-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Exceptions-UnexpectedException-#ctor-System-Runtime-Serialization-SerializationInfo,System-Runtime-Serialization-StreamingContext-'></a>
### #ctor() `constructor`

##### Summary

*Inherit from parent.*

##### Parameters

This constructor has no parameters.

<a name='T-Raccoon-Ninja-ValidatorDotNet-Constants-Constraints-Utc'></a>
## Utc `type`

##### Namespace

Raccoon.Ninja.ValidatorDotNet.Constants.Constraints

##### Summary

Limit values when dealing with UTC.

<a name='F-Raccoon-Ninja-ValidatorDotNet-Constants-Constraints-Utc-MaxValue'></a>
### MaxValue `constants`

##### Summary

Maximum acceptable value for UTC
    The Howland islands, an unincorporated unorganized territory of the United States, use a time zone of -12 hours UTC on the far west of the earth. The Republic of Kiribati’s Line Islands, which have a time zone of +14 hours UTC, are on the far east of the earth. These two places, therefore, have the biggest time difference of 26 hours.

<a name='F-Raccoon-Ninja-ValidatorDotNet-Constants-Constraints-Utc-MinValue'></a>
### MinValue `constants`

##### Summary

Minimum acceptable value for UTC

<a name='T-Raccoon-Ninja-ValidatorDotNet-Validate'></a>
## Validate `type`

##### Namespace

Raccoon.Ninja.ValidatorDotNet

##### Summary

Class containing all validation methods.
    Methods starting with Try will return a boolean, all others will thrown an exception.

<a name='M-Raccoon-Ninja-ValidatorDotNet-Validate-AllEnumValid``1-System-Collections-Generic-ICollection{``0},System-String-'></a>
### AllEnumValid\`\`1(list,label) `method`

##### Summary

Checks if all enums in a list are valid.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| list | [System.Collections.Generic.ICollection{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection 'System.Collections.Generic.ICollection{``0}') | to be checked |
| label | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Label to be used in the error message |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | type of enum |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Raccoon.Ninja.ValidatorDotNet.Exceptions.NullRequiredValueException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-NullRequiredValueException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NullRequiredValueException') | If list is null |
| [Raccoon.Ninja.ValidatorDotNet.Exceptions.InvalidEnumException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidEnumException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.InvalidEnumException') | If any of the Enums are invalid |

<a name='M-Raccoon-Ninja-ValidatorDotNet-Validate-AllPositiveElements``1-System-Collections-Generic-ICollection{``0},System-String-'></a>
### AllPositiveElements\`\`1(list,label) `method`

##### Summary

Checks if all elements of a list are positive.
    Zero does does not count, because the real numbers can be partitioned into the positive real numbers,
    the negative real numbers, and zero. A real number is one and only one of those three possibilities.
    This is called "trichotomy." Non-negative (or, correspondingly, non-positive) means not negative
    (not positive), so zero or positive (zero or negative). That is, non-negative includes zero whereas
    positive does not.
    For clarity:
    Non-negative means zero or positive.
    Non-positive means zero or negative.
    That is, non-negative includes zero whereas positive does not and vice versa.

##### Returns

None if OK.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| list | [System.Collections.Generic.ICollection{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection 'System.Collections.Generic.ICollection{``0}') | list to be checked |
| label | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Label to be used in the error message |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the elements of the list. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Raccoon.Ninja.ValidatorDotNet.Exceptions.NotAllNumbersPositiveException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotAllNumbersPositiveException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NotAllNumbersPositiveException') | If any element is lesser than or equal to zero. |

<a name='M-Raccoon-Ninja-ValidatorDotNet-Validate-CanBeInt-System-String-'></a>
### CanBeInt(text) `method`

##### Summary

Checks if a string can be converted to an Int.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to be converted. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Raccoon.Ninja.ValidatorDotNet.Exceptions.InvalidIntegerException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidIntegerException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.InvalidIntegerException') | If the text cannot be converted to an integer. |

<a name='M-Raccoon-Ninja-ValidatorDotNet-Validate-DynamicHasProperty-System-Object,System-String,System-String-'></a>
### DynamicHasProperty(obj,propertyName,label) `method`

##### Summary

Checks if a dynamic object has a certain property.
    Attention: The lookup is case sensitive!

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | object to be checked |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | param name |
| label | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Label to be used in the error message |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Raccoon.Ninja.ValidatorDotNet.Exceptions.DynamicPropertyNotFoundException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-DynamicPropertyNotFoundException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.DynamicPropertyNotFoundException') | If the object is null or only spaces |

<a name='M-Raccoon-Ninja-ValidatorDotNet-Validate-HasElements``1-System-Collections-Generic-ICollection{``0},System-String-'></a>
### HasElements\`\`1(list,label) `method`

##### Summary

Checks if a list has any elements.
    If it's null, will return false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| list | [System.Collections.Generic.ICollection{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection 'System.Collections.Generic.ICollection{``0}') | Object to be checked |
| label | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Label to be used in the error message |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the list |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Raccoon.Ninja.ValidatorDotNet.Exceptions.EmptyListException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-EmptyListException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.EmptyListException') | If the object is null or the list is empty. |

<a name='M-Raccoon-Ninja-ValidatorDotNet-Validate-IsDateTimeAfterMin-System-DateTime,System-String,System-Nullable{System-DateTime}-'></a>
### IsDateTimeAfterMin(dt,label,minDate) `method`

##### Summary

Checks if a datetime is after (or the equal to) the minimum value passed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dt | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | object to be checked |
| label | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Label to be used in the error message |
| minDate | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | Minimum DateTime allowed. By default, will use Sql Server minimum |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Raccoon.Ninja.ValidatorDotNet.Exceptions.NotGreaterThanOrEqualToException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotGreaterThanOrEqualToException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NotGreaterThanOrEqualToException') | if DateTime object is before the minimum accepted |

<a name='M-Raccoon-Ninja-ValidatorDotNet-Validate-IsDateTimeUtc-System-DateTime,System-String-'></a>
### IsDateTimeUtc(dt,label) `method`

##### Summary

Checks if a given datetime is set to UTC.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dt | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | object to be checked |
| label | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Label to be used in the error message |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Raccoon.Ninja.ValidatorDotNet.Exceptions.DateTimeNotInUtcException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-DateTimeNotInUtcException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.DateTimeNotInUtcException') | If the datetime is not set to UTC. |

<a name='M-Raccoon-Ninja-ValidatorDotNet-Validate-IsEnumValid``1-``0,System-String-'></a>
### IsEnumValid\`\`1(enumObj,label) `method`

##### Summary

Validates if an Enum is defined or not.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumObj | [\`\`0](#T-``0 '``0') | to be validated |
| label | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Label to be used in the error message |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TEnum | type of Enum |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Raccoon.Ninja.ValidatorDotNet.Exceptions.InvalidEnumException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidEnumException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.InvalidEnumException') | if value is not a valid Enum of type T |

<a name='M-Raccoon-Ninja-ValidatorDotNet-Validate-IsEqualTo``1-``0,``0,System-String-'></a>
### IsEqualTo\`\`1(a,b,label) `method`

##### Summary

Checks if A is equal to B.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [\`\`0](#T-``0 '``0') | An object |
| b | [\`\`0](#T-``0 '``0') | Reference object |
| label | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Label to be used in the error message |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of parameters. Must be something that can be used with arithmetic operations |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Raccoon.Ninja.ValidatorDotNet.Exceptions.NotEqualToException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotEqualToException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NotEqualToException') | If a is not equal to b. |

<a name='M-Raccoon-Ninja-ValidatorDotNet-Validate-IsGreaterThanOrEqualTo``1-``0,``0,System-String-'></a>
### IsGreaterThanOrEqualTo\`\`1(a,b,label) `method`

##### Summary

Checks if A is greater than or equal to B.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [\`\`0](#T-``0 '``0') | An object |
| b | [\`\`0](#T-``0 '``0') | Reference object |
| label | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Label to be used in the error message |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of parameters. Must be something that can be used with arithmetic operations |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Raccoon.Ninja.ValidatorDotNet.Exceptions.NotGreaterThanOrEqualToException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotGreaterThanOrEqualToException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NotGreaterThanOrEqualToException') | If a is not greater than b. |

<a name='M-Raccoon-Ninja-ValidatorDotNet-Validate-IsGreaterThan``1-``0,``0,System-String-'></a>
### IsGreaterThan\`\`1(a,b,label) `method`

##### Summary

Checks if A is greater than B.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [\`\`0](#T-``0 '``0') | An object |
| b | [\`\`0](#T-``0 '``0') | Reference object |
| label | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Label to be used in the error message |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of parameters. Must be something that can be used with arithmetic operations |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Raccoon.Ninja.ValidatorDotNet.Exceptions.NotGreaterThanException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotGreaterThanException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NotGreaterThanException') | If a is not greater than or equal to b. |

<a name='M-Raccoon-Ninja-ValidatorDotNet-Validate-IsGuidValid-System-String,System-String-'></a>
### IsGuidValid(guid,label) `method`

##### Summary

Validates if a Guid is not an Empty one.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| guid | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | guid to be checked |
| label | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Label to be used in the error message |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Raccoon.Ninja.ValidatorDotNet.Exceptions.InvalidGuidException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-InvalidGuidException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.InvalidGuidException') | If the guid is empty. |

<a name='M-Raccoon-Ninja-ValidatorDotNet-Validate-IsLessThanOrEqualTo``1-``0,``0,System-String-'></a>
### IsLessThanOrEqualTo\`\`1(a,b,label) `method`

##### Summary

Checks if A is less than or equal to B.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [\`\`0](#T-``0 '``0') | An object |
| b | [\`\`0](#T-``0 '``0') | Reference object |
| label | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Label to be used in the error message |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of parameters. Must be something that can be used with arithmetic operations |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Raccoon.Ninja.ValidatorDotNet.Exceptions.NotLessThanOrEqualToException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotLessThanOrEqualToException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NotLessThanOrEqualToException') | If a is greater than b. |

<a name='M-Raccoon-Ninja-ValidatorDotNet-Validate-IsLessThan``1-``0,``0,System-String-'></a>
### IsLessThan\`\`1(a,b,label) `method`

##### Summary

Checks if A is lesser than B.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [\`\`0](#T-``0 '``0') | An object |
| b | [\`\`0](#T-``0 '``0') | Reference object |
| label | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Label to be used in the error message |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of parameters. Must be something that can be used with arithmetic operations |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Raccoon.Ninja.ValidatorDotNet.Exceptions.NotLessThanOrEqualToException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-NotLessThanOrEqualToException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NotLessThanOrEqualToException') | If a is greater than or equal to b. |

<a name='M-Raccoon-Ninja-ValidatorDotNet-Validate-IsNotNull-System-Object,System-String-'></a>
### IsNotNull(obj,label) `method`

##### Summary

Checks if an object is null.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | object to be checked |
| label | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Label to be used in the error message |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Raccoon.Ninja.ValidatorDotNet.Exceptions.NullRequiredValueException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-NullRequiredValueException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.NullRequiredValueException') | If the object is null |

<a name='M-Raccoon-Ninja-ValidatorDotNet-Validate-IsTextNotNull-System-String,System-String-'></a>
### IsTextNotNull(text,label) `method`

##### Summary

Checks if a text is not null or composed only by whitespaces.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | object to be checked |
| label | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Label to be used in the error message |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Raccoon.Ninja.ValidatorDotNet.Exceptions.TextNullOrEmptyException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-TextNullOrEmptyException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.TextNullOrEmptyException') | If the object is null or only spaces |

<a name='M-Raccoon-Ninja-ValidatorDotNet-Validate-IsTextWithinCharLimit-System-String,System-Int32,System-String-'></a>
### IsTextWithinCharLimit(text,maxChars,label) `method`

##### Summary

Checks if a given string has less than or the same amount of chars indicated be the argument.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | text to validate |
| maxChars | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | maximum chars |
| label | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Label to be used in the error message |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Raccoon.Ninja.ValidatorDotNet.Exceptions.TextTooBigException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-TextTooBigException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.TextTooBigException') | If text exceeds maxChars |
| [Raccoon.Ninja.ValidatorDotNet.Exceptions.TextNullOrEmptyException](#T-Raccoon-Ninja-ValidatorDotNet-Exceptions-TextNullOrEmptyException 'Raccoon.Ninja.ValidatorDotNet.Exceptions.TextNullOrEmptyException') | If the object is null or only spaces |

<a name='M-Raccoon-Ninja-ValidatorDotNet-Validate-IsUtcOffsetValid-System-Int32,System-String-'></a>
### IsUtcOffsetValid(utcOffset,label) `method`

##### Summary

Checks if an integer represents a valid UTC offset.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| utcOffset | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | to be checked |
| label | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Label to be used in the error message |

<a name='M-Raccoon-Ninja-ValidatorDotNet-Validate-TryAllPositiveElements``1-System-Collections-Generic-ICollection{``0}-'></a>
### TryAllPositiveElements\`\`1(list) `method`

##### Summary

Checks if all elements of a list are positive.
    Zero does does not count, because the real numbers can be partitioned into the positive real numbers,
    the negative real numbers, and zero. A real number is one and only one of those three possibilities.
    This is called "trichotomy." Non-negative (or, correspondingly, non-positive) means not negative
    (not positive), so zero or positive (zero or negative). That is, non-negative includes zero whereas
    positive does not.
    For clarity:
    Non-negative means zero or positive.
    Non-positive means zero or negative.
    That is, non-negative includes zero whereas positive does not and vice versa.

##### Returns

True if all elements are numeric AND positive.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| list | [System.Collections.Generic.ICollection{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection 'System.Collections.Generic.ICollection{``0}') | list to be checked |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the elements of the list. |

<a name='M-Raccoon-Ninja-ValidatorDotNet-Validate-TryCanBeInt-System-String-'></a>
### TryCanBeInt(text) `method`

##### Summary

Checks if a string can be converted to an Int.

##### Returns

true if it can/false otherwise

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Text to be converted. |

<a name='M-Raccoon-Ninja-ValidatorDotNet-Validate-TryDynamicHasProperty-System-Object,System-String-'></a>
### TryDynamicHasProperty(obj,propertyName) `method`

##### Summary

Checks if a dynamic object has a certain property.
    Attention: The lookup is case sensitive!

##### Returns

true if has parameter/false otherwise

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | object to be checked |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | param name |

<a name='M-Raccoon-Ninja-ValidatorDotNet-Validate-TryHasElements``1-System-Collections-Generic-ICollection{``0}-'></a>
### TryHasElements\`\`1(list) `method`

##### Summary

Checks if a list has any elements.
    If it's null, will return false.

##### Returns

true if it has any elements/false otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| list | [System.Collections.Generic.ICollection{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection 'System.Collections.Generic.ICollection{``0}') | Object to be checked |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of the list |

<a name='M-Raccoon-Ninja-ValidatorDotNet-Validate-TryIsDateTimeAfterMin-System-DateTime,System-Nullable{System-DateTime}-'></a>
### TryIsDateTimeAfterMin(dt,minDate) `method`

##### Summary

Checks if a datetime is after (or the equal to) the minimum value passed.

##### Returns

true if it is/false otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dt | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | object to be checked |
| minDate | [System.Nullable{System.DateTime}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable{System.DateTime}') | Minimum DateTime allowed. By default, will use Sql Server minimum |

<a name='M-Raccoon-Ninja-ValidatorDotNet-Validate-TryIsDateTimeUtc-System-DateTime-'></a>
### TryIsDateTimeUtc(dt) `method`

##### Summary

Checks if a given datetime is set to UTC.

##### Returns

true if it is set to UTC/false otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dt | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | object to be checked |

<a name='M-Raccoon-Ninja-ValidatorDotNet-Validate-TryIsEnumValid``1-``0-'></a>
### TryIsEnumValid\`\`1(enumObj) `method`

##### Summary

Validates if an Enum is defined or not.

##### Returns

true if it is. false otherwise

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumObj | [\`\`0](#T-``0 '``0') | to be validated |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | type of Enum |

<a name='M-Raccoon-Ninja-ValidatorDotNet-Validate-TryIsEqualTo``1-``0,``0-'></a>
### TryIsEqualTo\`\`1(a,b) `method`

##### Summary

Checks if A is equal to B.

##### Returns

true if A is equal to B/false otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [\`\`0](#T-``0 '``0') | An object |
| b | [\`\`0](#T-``0 '``0') | Reference object |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of parameters. Must be something that can be used with arithmetic operations |

<a name='M-Raccoon-Ninja-ValidatorDotNet-Validate-TryIsGreaterThanOrEqualTo``1-``0,``0-'></a>
### TryIsGreaterThanOrEqualTo\`\`1(a,b) `method`

##### Summary

Checks if A is greater than or equal to B.

##### Returns

true if A is greater than or equal to B/false otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [\`\`0](#T-``0 '``0') | An object |
| b | [\`\`0](#T-``0 '``0') | Reference object |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of parameters. Must be something that can be used with arithmetic operations |

<a name='M-Raccoon-Ninja-ValidatorDotNet-Validate-TryIsGreaterThan``1-``0,``0-'></a>
### TryIsGreaterThan\`\`1(a,b) `method`

##### Summary

Checks if A is greater than B.

##### Returns

true if A is greater than B/false otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [\`\`0](#T-``0 '``0') | An object |
| b | [\`\`0](#T-``0 '``0') | Reference object |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of parameters. Must be something that can be used with arithmetic operations |

<a name='M-Raccoon-Ninja-ValidatorDotNet-Validate-TryIsLessThanOrEqualTo``1-``0,``0-'></a>
### TryIsLessThanOrEqualTo\`\`1(a,b) `method`

##### Summary

Checks if A is less than or equal to B.

##### Returns

true if A is less than or equal to B/false otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [\`\`0](#T-``0 '``0') | An object |
| b | [\`\`0](#T-``0 '``0') | Reference object |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of parameters. Must be something that can be used with arithmetic operations |

<a name='M-Raccoon-Ninja-ValidatorDotNet-Validate-TryIsLessThan``1-``0,``0-'></a>
### TryIsLessThan\`\`1(a,b) `method`

##### Summary

Checks if A is less than B.

##### Returns

true if A is less than B/false otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| a | [\`\`0](#T-``0 '``0') | An object |
| b | [\`\`0](#T-``0 '``0') | Reference object |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type of parameters. Must be something that can be used with arithmetic operations |

<a name='M-Raccoon-Ninja-ValidatorDotNet-Validate-TryIsNull-System-Object-'></a>
### TryIsNull(obj) `method`

##### Summary

Checks if an object is null.

##### Returns

true if it is null/false otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | object to be checked |

<a name='M-Raccoon-Ninja-ValidatorDotNet-Validate-TryIsTextNull-System-String-'></a>
### TryIsTextNull(text) `method`

##### Summary

Checks if a text is null or composed only by whitespaces.

##### Returns

true if it is null/false otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | object to be checked |

<a name='M-Raccoon-Ninja-ValidatorDotNet-Validate-TryIsTextWithinCharLimit-System-String,System-Int32-'></a>
### TryIsTextWithinCharLimit(text,maxChars) `method`

##### Summary

Checks if a given string has less than or the same amount of chars indicated be the argument.

##### Returns

true if it has lesser than or the same amount of chars/false otherwise

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | text to validate |
| maxChars | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | maximum chars |

<a name='M-Raccoon-Ninja-ValidatorDotNet-Validate-TryIsValidGuid-System-String-'></a>
### TryIsValidGuid(guid) `method`

##### Summary

Validates if a Guid is not an Empty one.

##### Returns

true if it's not an empty guid, false otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| guid | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | guid to be checked |

<a name='M-Raccoon-Ninja-ValidatorDotNet-Validate-TryIsValidUtcOffset-System-Int32-'></a>
### TryIsValidUtcOffset(utcOffset) `method`

##### Summary

Checks if an integer represents a valid UTC offset.

##### Returns

true if it is a valid utc-offset, false otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| utcOffset | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | to be checked |

<a name='T-ValidatorDotNet-ValidationErrorMessages'></a>
## ValidationErrorMessages `type`

##### Namespace

ValidatorDotNet

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-ValidatorDotNet-ValidationErrorMessages-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-ValidatorDotNet-ValidationErrorMessages-DateTimeNotInUTC'></a>
### DateTimeNotInUTC `property`

##### Summary

Looks up a localized string similar to Parameter '{0}' has a DateTime value of '{1}', but it is not in UTC.

<a name='P-ValidatorDotNet-ValidationErrorMessages-DynamicPropMissing'></a>
### DynamicPropMissing `property`

##### Summary

Looks up a localized string similar to Property '{0}' of {1} is missing.

<a name='P-ValidatorDotNet-ValidationErrorMessages-EmptyList'></a>
### EmptyList `property`

##### Summary

Looks up a localized string similar to No items found in the parameter '{0}'.

<a name='P-ValidatorDotNet-ValidationErrorMessages-InvalidEnumList'></a>
### InvalidEnumList `property`

##### Summary

Looks up a localized string similar to The list in parameter '{0}'  contains invalid {0} enums.

<a name='P-ValidatorDotNet-ValidationErrorMessages-InvalidEnumValue'></a>
### InvalidEnumValue `property`

##### Summary

Looks up a localized string similar to Parameter '{0}' has a value of '{1}' but it is not a valid enum of type '{1}'.

<a name='P-ValidatorDotNet-ValidationErrorMessages-InvalidGuid'></a>
### InvalidGuid `property`

##### Summary

Looks up a localized string similar to Guid that identifies {0} is empty or invalid.

<a name='P-ValidatorDotNet-ValidationErrorMessages-InvalidUtcValue'></a>
### InvalidUtcValue `property`

##### Summary

Looks up a localized string similar to Parameter '{0}' has a invalid utcoffset value of '{1}'. It must be between '{2}' and '{3}'.

<a name='P-ValidatorDotNet-ValidationErrorMessages-MultiRowsAffectedById'></a>
### MultiRowsAffectedById `property`

##### Summary

Looks up a localized string similar to WARNING! Found '{0}' affected rows of type {0} with id {1}.

<a name='P-ValidatorDotNet-ValidationErrorMessages-NoEntryWithId'></a>
### NoEntryWithId `property`

##### Summary

Looks up a localized string similar to No entry of type '{0}' found with id '{1}'.

<a name='P-ValidatorDotNet-ValidationErrorMessages-NotAllNumbersArePositive'></a>
### NotAllNumbersArePositive `property`

##### Summary

Looks up a localized string similar to Not all numbers in the list '{0}' are positive.

<a name='P-ValidatorDotNet-ValidationErrorMessages-NotEqualTo'></a>
### NotEqualTo `property`

##### Summary

Looks up a localized string similar to Expecting parameter '{0}' to have a value of '{1}', but got '{2}' instead.

<a name='P-ValidatorDotNet-ValidationErrorMessages-NotGreaterThan'></a>
### NotGreaterThan `property`

##### Summary

Looks up a localized string similar to Expecting a value greather than '{0}' for parameter '{1}', but got  '{2}' instead.

<a name='P-ValidatorDotNet-ValidationErrorMessages-NotGreaterThanOrEqualTo'></a>
### NotGreaterThanOrEqualTo `property`

##### Summary

Looks up a localized string similar to Expecting a value greather than or equal to '{0}' for parameter '{1}', but got '{2}' instead.

<a name='P-ValidatorDotNet-ValidationErrorMessages-NotLessThan'></a>
### NotLessThan `property`

##### Summary

Looks up a localized string similar to Expecting a value lesser than '{0}' for parameter '{1}', but got  '{2}' instead.

<a name='P-ValidatorDotNet-ValidationErrorMessages-NotLessThanOrEqualTo'></a>
### NotLessThanOrEqualTo `property`

##### Summary

Looks up a localized string similar to Expecting a value lesser than or equal to '{0}' for parameter '{1}', but got  '{2}' instead.

<a name='P-ValidatorDotNet-ValidationErrorMessages-NullRequiredValue'></a>
### NullRequiredValue `property`

##### Summary

Looks up a localized string similar to Parameter {0} is required and cannot be null/empty.

<a name='P-ValidatorDotNet-ValidationErrorMessages-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='P-ValidatorDotNet-ValidationErrorMessages-StringIsNotANumber'></a>
### StringIsNotANumber `property`

##### Summary

Looks up a localized string similar to The string '{0}' cannot be converted to number.

<a name='P-ValidatorDotNet-ValidationErrorMessages-TextSizeExceededMaxChars'></a>
### TextSizeExceededMaxChars `property`

##### Summary

Looks up a localized string similar to Size of {0} exceeded {1} characters.

<a name='T-Raccoon-Ninja-ValidatorDotNet-ExtensionMethods-ValueTypeExtensions'></a>
## ValueTypeExtensions `type`

##### Namespace

Raccoon.Ninja.ValidatorDotNet.ExtensionMethods

##### Summary

Extension methods for ValueType variables.

<a name='M-Raccoon-Ninja-ValidatorDotNet-ExtensionMethods-ValueTypeExtensions-IsNumeric-System-ValueType-'></a>
### IsNumeric(value) `method`

##### Summary

Checks if this ValueType instance is from any of the numeric types.
    Enums are not numbers but, by default, they have an underlying integral numeric type, as can
    be referenced in the official docs. For this reason, they will be considered as numeric.
    Reference: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum

##### Returns

True if it is, false otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.ValueType](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ValueType 'System.ValueType') | value to be checked |
