# Validator .Net
[Quality Gate Status](https://sonar.dtidigital.com.br/api/project_badges/measure?project=Raccoon.Ninja.ValidatorDotNet&metric=alert_status)



This project consist in a handful of convenience methods to perform common validations. You can try to validate something, in which case the method will return a boolean or do a "hard validation" that will throw an exception in case of failure.

All exceptions are in a hierarchy, ensuring ease of use while working with try-catches.

The motivation for this project was to centralize validation helpers and reduce code duplication across a myriad of internal projects. 

The idea here is not to replace simple if statements, but to create a standardized and clean way to make validations and capture exceptions when any errors occur.

# Exception hierarchy
- System.Exception
	- BaseValidationException
		- DynamicPropertyNotFoundException
		- EmptyListException
		- NoRowsAffecetedException
		- TextTooBigException
		- UnexpecctedException
		- ElementComparisonException
			- NotEqualToException
			- NotGreaterThanException
			- NotGreaterThanOrEqualToException
			- NotLessThanException
			- NotLessThanOrEqualToException
			- TypingException
				- DateTimeNotInUtcException
				- InvalidEnumException
				- InvalidGuidException
				- NullRequiredValueException
					- TextNullOrEmptyException
				- NumberException
					- InvalidIntegerException
					- InvalidUtcOffsetException
					- NotAllNumbersPositiveException

# Documentation
The documentation is autogenerated. I'm not happy with it, but it's a start.
[ValidatorDotNet.Documentation.md](ValidatorDotNet.Documentation.md)