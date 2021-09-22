using System;
using System.Collections.Generic;
using Raccoon.Ninja.ValidatorDotNet.Constants;
using Raccoon.Ninja.ValidatorDotNet.Exceptions;
using Raccoon.Ninja.ValidatorDotNet.Internationalization;
using Raccoon.Ninja.ValidatorDotNet.Tests.Mocks;
using ValidatorDotNet;
using Xunit;

namespace Raccoon.Ninja.ValidatorDotNet.Tests
{
    public class ValidateTest
    {
        #region Success Tests

        [Fact]
        public void IsGreaterThan_Success()
        {
            Validate.IsGreaterThan(2,1);
        }
        
        [Fact]
        public void IsGreaterThanOrEqualTo_Success()
        {
            Validate.IsGreaterThanOrEqualTo(2,1);
            Validate.IsGreaterThanOrEqualTo(1,1);
        }
        
        [Fact]
        public void IsLessThan_Success()
        {
            Validate.IsLessThan(1,2);
        }
        
        [Fact]
        public void IsLessThanOrEqualTo_Success()
        {
            Validate.IsLessThanOrEqualTo(1,2);
            Validate.IsLessThanOrEqualTo(1,1);
        }
        
        [Fact]
        public void IsEqualTo_Success()
        {
            Validate.IsEqualTo(1,1);
        }
        
        [Fact]
        public void IsDateTimeUtc_Success()
        {
            Validate.IsDateTimeUtc(DateTime.UtcNow);
        }
        
        [Fact]
        public void IsDateTimeAfterMin_Success()
        {
            Validate.IsDateTimeAfterMin(DateTime.UtcNow);
        }
        
        [Fact]
        public void IsEnumValid_Success()
        {
            Validate.IsEnumValid(EnumMock.Bar);
        }
        
        [Fact]
        public void AllEnumValid_Success()
        {
            Validate.AllEnumValid(new List<EnumMock> {EnumMock.Bar, EnumMock.Foo});
        }
        
        [Fact]
        public void AllEnumValid_Empty_Success()
        {
            Validate.AllEnumValid(new List<EnumMock>());
        }
        
        [Fact]
        public void IsGuidValid_Success()
        {
            Validate.IsGuidValid(Guid.NewGuid().ToString());
        }
                
        [Fact]
        public void IsUtcOffsetValid_Success()
        {
            Validate.IsUtcOffsetValid(180);
        }
        
        [Fact]
        public void TryIsTextWithinCharLimit_Success_Bigger()
        {
            Assert.False(Validate.TryIsTextWithinCharLimit("foo", 1));
        }

        [Theory]
        [InlineData("f")]
        [InlineData("fo")]
        [InlineData("foo")]
        public void TryIsTextWithinCharLimit_Success_SameSize(string text)
        {
            Assert.True(Validate.TryIsTextWithinCharLimit(text, 3));
        }

        [Fact]
        public void IsTextWithinCharLimit_Success_SameSize()
        {
            Validate.IsTextWithinCharLimit("foo", 3);
        }

        [Fact]
        public void IsTextWithinCharLimit_Success_Smaller()
        {
            Validate.IsTextWithinCharLimit("foo", 100, "label");
        }

        [Fact]
        public void TryIsSingleRowAffected_Success_NoRowsAffected()
        {
            Assert.True(Validate.Specializations.TryIsSingleRowAffectedForId(0, true));
        }

        [Fact]
        public void TryIsSingleRowAffected_Success_SingleRowAffected()
        {
            Assert.True(Validate.Specializations.TryIsSingleRowAffectedForId(1));
        }

        [Fact]
        public void IsSingleRowAffected_Success_SingleRowAffected()
        {
            Validate.Specializations.IsSingleRowAffectedForId(1, 4, "label");
        }

        [Fact]
        public void TryIsNull_Success()
        {
            Assert.True(Validate.TryIsNull(null));
            Assert.False(Validate.TryIsNull(new object()));
        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]
        public void TryIsTextNotNull_Success_TextNullOrWhiteSpace(string value)
        {
            Assert.True(Validate.TryIsTextNull(value));
        }

        [Fact]
        public void TryDynamicHasProperty_Success()
        {
            var objectToCheck = new
            {
                name = "TryDynamicHasProperty",
                age = 1
            };
            Assert.True(Validate.TryDynamicHasProperty(objectToCheck, "name"));
            Assert.False(Validate.TryDynamicHasProperty(objectToCheck, "phone"));
        }

        [Fact]
        public void TryCanBeInt_Success()
        {
            Assert.True(Validate.TryCanBeInt("1"));
            Assert.False(Validate.TryCanBeInt("a"));
        }

        [Fact]
        public void TryHasElements_Success()
        {
            var listToCheck = new List<string>
            {
                "item 1",
                "item 2",
                "item 3"
            };

            Assert.True(Validate.TryHasElements(listToCheck));
            Assert.False(Validate.TryHasElements(new List<string>()));
            Assert.False(Validate.TryHasElements<List<string>>(null));
        }

        [Fact]
        public void IsNotNull_Success()
        {
            Validate.IsNotNull(new object());
        }

        [Fact]
        public void IsTextNotNull_Success()
        {
            Validate.IsTextNotNull("test");
        }

        [Fact]
        public void DynamicHasProperty_Success()
        {
            var objectToCheck = new
            {
                name = "DynamicHasProperty"
            };

            Validate.DynamicHasProperty(objectToCheck, "name");
        }

        [Fact]
        public void CanBeInt_Success()
        {
            Validate.CanBeInt("1");
        }

        [Fact]
        public void HasElements_Success()
        {
            var listToCheck = new List<string>
            {
                "item 1",
                "item 2",
                "item 3"
            };

            Validate.HasElements(listToCheck);
        }

        [Fact]
        public void TryAllPositiveElements_Success_Null()
        {
            Assert.False(Validate.TryAllPositiveElements((List<int>)null));
        }

        [Fact]
        public void TryAllPositiveElements_Success_Empty()
        {
            Assert.False(Validate.TryAllPositiveElements(new List<int>()));
        }

        [Theory]
        [InlineData(1, 0)]
        [InlineData(1, 1)]
        public void TryIsGreaterThanOrEqualTo_Success_True(int a, int b)
        {
            Assert.True(Validate.TryIsGreaterThanOrEqualTo(a, b));
        }

        [Theory]
        [InlineData(1, 10)]
        [InlineData(1, 11)]
        public void TryIsGreaterThanOrEqualTo_Success_False(int a, int b)
        {
            Assert.False(Validate.TryIsGreaterThanOrEqualTo(a, b));
        }

        [Fact]
        public void AllPositiveElements_Success_NoError()
        {
            Validate.AllPositiveElements(new List<int> { 1, 2, 3 });
        }

        #endregion

        #region Error Tests

        [Fact]
        public void IsTextWithinCharLimit_Error_TextTooBig()
        {
            const string label = "IsTextWithinCharLimit";
            const string text = "FooBar";
            const int maxSize = 3;

            var exception =
                Assert.Throws<TextTooBigException>(() => Validate.IsTextWithinCharLimit(text, maxSize, label));
            var expected = string.Format(ValidationErrorMessages.TextSizeExceededMaxChars, label, maxSize);
            Assert.Equal(expected, exception.Message);
        }

        [Fact]
        public void IsSingleRowAffected_Error_NoRowsAffected()
        {
            const string label = "IsSingleRowAffected";
            const int id = 42;
            var exception = Assert.Throws<NoRowsAffectedException>(() =>
                Validate.Specializations.IsSingleRowAffectedForId(0, id, label, false));
            var expected = string.Format(ValidationErrorMessages.NoEntryWithId, label, id);
            Assert.Equal(expected, exception.Message);
        }

        [Fact]
        public void IsSingleRowAffected_Error_MultiRowsAffected()
        {
            const string label = "IsSingleRowAffected";
            const int id = 42;
            const int affectedRows = 5;
            var exception = Assert.Throws<UnexpectedException>(() =>
                Validate.Specializations.IsSingleRowAffectedForId(affectedRows, id, label, false));
            var expected = string.Format(ValidationErrorMessages.MultiRowsAffectedById, affectedRows, label, id);
            Assert.Equal(expected, exception.Message);
        }

        [Fact]
        public void IsNotNull_Error()
        {
            new List<string>() { "IsNotNull_Error_label", null }.ForEach(label =>
            {
                var exception = Assert.Throws<NullRequiredValueException>(() => Validate.IsNotNull(null, label));
                var expected = string.Format(ValidationErrorMessages.NullRequiredValue, label ?? DefaultLabels.Object);
                Assert.Equal(expected, exception.Message);
            });
        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]
        public void IsTextNotNull_Error(string value)
        {
            new List<string>() { "IsTextNull", null }.ForEach(label =>
            {
                var exception = Assert.Throws<TextNullOrEmptyException>(() => Validate.IsTextNotNull(value, label));
                var expected = string.Format(ValidationErrorMessages.NullRequiredValue, label ?? DefaultLabels.Text);
                Assert.Equal(expected, exception.Message);
            });
        }

        [Fact]
        public void DynamicHasProperty_Error()
        {
            const string propName = "prop";

            new List<string>() { "DynamicObject", null }.ForEach(label =>
            {
                var exception =
                    Assert.Throws<DynamicPropertyNotFoundException>(
                        () => Validate.DynamicHasProperty(new object(), propName, label));


                var expected = string.Format(ValidationErrorMessages.DynamicPropMissing, propName,
                    label ?? DefaultLabels.Object);
                Assert.Equal(expected, exception.Message);
            });
        }

        [Fact]
        public void TryDynamicHasProperty_Null_Error()
        {
            Assert.False(Validate.TryDynamicHasProperty(null, "propName"));
        }

        [Fact]
        public void TryAllPositiveElements_NotANumber_Error()
        {
            Assert.False(Validate.TryAllPositiveElements(new List<bool>{true, false}));
        }
        
        [Fact]
        public void TryISDateTimeAfterMin_Success_DefaultMinDate()
        {
            Assert.True(Validate.TryIsDateTimeAfterMin(DateTime.UtcNow));
        }
        
        [Fact]
        public void CanBeInt_Error_CanNotBeInt()
        {
            const string text = "a";
            var exception = Assert.Throws<InvalidIntegerException>(() => Validate.CanBeInt(text));
            var expected = string.Format(ValidationErrorMessages.StringIsNotANumber, text);
            Assert.Equal(expected, exception.Message);
        }

        [Theory]
        [InlineData("")]
        [InlineData(" ")]
        [InlineData(null)]
        public void CanBeInt_Error_TextIsNull(string value)
        {
            var exception = Assert.Throws<TextNullOrEmptyException>(() => Validate.CanBeInt(value));
            var expected = string.Format(ValidationErrorMessages.NullRequiredValue, "text");
            Assert.Equal(expected, exception.Message);
        }

        [Fact]
        public void HasElements_Error()
        {
            new List<string>() { "HasElements_Error", null }.ForEach(label =>
            {
                var exception =
                    Assert.Throws<EmptyListException>(() => Validate.HasElements(new List<string>(), label));

                var expected = string.Format(ValidationErrorMessages.EmptyList, label ?? DefaultLabels.List);
                Assert.Equal(expected, exception.Message);
            });
        }

        [Fact]
        public void AllPositiveElements_Error()
        {
            new List<string>() { "AllPositiveElements_Error", null }.ForEach(label =>
            {
                var exception =
                    Assert.Throws<NotAllNumbersPositiveException>(() =>
                        Validate.AllPositiveElements(new List<int> { 1, 2, 3, -4, 5, 6, 7 }, label));

                var expected = string.Format(ValidationErrorMessages.NotAllNumbersArePositive, label ?? DefaultLabels.List);
                Assert.Equal(expected, exception.Message);
            });
        }
        
        [Fact]
        public void IsGreaterThan_Error()
        {
            new List<string>() { "IsGreaterThan_Error", null }.ForEach(label =>
            {
                var exception =
                    Assert.Throws<NotGreaterThanException>(() =>
                        Validate.IsGreaterThan(1, 2, label));

                var expected = string.Format(ValidationErrorMessages.NotGreaterThan, 2, label ?? DefaultLabels.Parameter, 1);
                Assert.Equal(expected, exception.Message);
            });
        }

        [Fact]
        public void IsGreaterThanOrEqualTo_Error()
        {
            new List<string>() { "IsGreaterThanOrEqualTo_Error", null }.ForEach(label =>
            {
                var exception =
                    Assert.Throws<NotGreaterThanException>(() =>
                        Validate.IsGreaterThanOrEqualTo(1, 2, label));

                var expected = string.Format(ValidationErrorMessages.NotGreaterThanOrEqualTo, 2, label ?? DefaultLabels.Parameter, 1);
                Assert.Equal(expected, exception.Message);
            });
        }
        
        [Fact]
        public void IsLessThan_Error()
        {
            new List<string>() { "IsLessThan_Error", null }.ForEach(label =>
            {
                var exception =
                    Assert.Throws<NotLessThanException>(() =>
                        Validate.IsLessThan(2, 1, label));

                var expected = string.Format(ValidationErrorMessages.NotLessThan, 1, label ?? DefaultLabels.Parameter, 2);
                Assert.Equal(expected, exception.Message);
            });
        }

        [Fact]
        public void IsLessThanOrEqualTo_Error()
        {
            new List<string>() { "IsLessThanOrEqualTo_Error", null }.ForEach(label =>
            {
                var exception =
                    Assert.Throws<NotLessThanOrEqualToException>(() =>
                        Validate.IsLessThanOrEqualTo(2, 1, label));

                var expected = string.Format(ValidationErrorMessages.NotLessThanOrEqualTo, 1, label ?? DefaultLabels.Parameter, 2);
                Assert.Equal(expected, exception.Message);
            });
        }   
        
        [Fact]
        public void IsEqualTo_Error()
        {
            new List<string>() { "IsEqualTo_Error", null }.ForEach(label =>
            {
                var exception =
                    Assert.Throws<NotEqualToException>(() =>
                        Validate.IsEqualTo(2, 1, label));

                var expected = string.Format(ValidationErrorMessages.NotEqualTo, label ?? DefaultLabels.Parameter, 1, 2);
                Assert.Equal(expected, exception.Message);
            });
        }  
        
        [Fact]
        public void IsDateTimeUtc_Error()
        {
            new List<string>() { "IsDateTimeUtc_Error", null }.ForEach(label =>
            {
                var now = DateTime.Now;
                
                var exception =
                    Assert.Throws<DateTimeNotInUtcException>(() =>
                        Validate.IsDateTimeUtc(now, label));

                var expected = string.Format(ValidationErrorMessages.DateTimeNotInUTC, label ?? DefaultLabels.Parameter, now);
                Assert.Equal(expected, exception.Message);
            });
        }  
        
        [Fact]
        public void IsDateTimeAfterMin_Error()
        {
            new List<string>() { "IsDateTimeAfterMin_Error", null }.ForEach(label =>
            {
                var now = DateTime.MinValue;
                
                var exception =
                    Assert.Throws<NotGreaterThanOrEqualToException>(() =>
                        Validate.IsDateTimeAfterMin(now, label));

                var expected = string.Format(
                    ValidationErrorMessages.NotGreaterThanOrEqualTo, 
                    Constraints.MinDateForDatabase.SqlServer, 
                    label ?? DefaultLabels.Parameter, 
                    now);
                Assert.Equal(expected, exception.Message);
            });
        }  
        
        
        [Fact]
        public void IsEnumValid_Error()
        {
            new List<string>() { "IsEnumValid_Error", null }.ForEach(label =>
            {
                EnumMock enumMock = 0;
                
                var exception =
                    Assert.Throws<InvalidEnumException>(() =>
                        Validate.IsEnumValid(enumMock, label));

                var expected = string.Format(
                    ValidationErrorMessages.InvalidEnumValue,
                    label ?? DefaultLabels.Parameter, 
                    enumMock,
                    "EnumMock");
                Assert.Equal(expected, exception.Message);
            });
        }
        
        [Fact]
        public void AllEnumValid_Error()
        {
            new List<string>() { "AllEnumValid_Error", null }.ForEach(label =>
            {
                var list = new List<EnumMock>
                {
                    EnumMock.Bar, 0, EnumMock.Foo
                };
                
                var exception =
                    Assert.Throws<InvalidEnumException>(() =>
                        Validate.AllEnumValid(list, label));

                var expected = string.Format(
                    ValidationErrorMessages.InvalidEnumList,
                    label ?? DefaultLabels.List,
                    "EnumMock");
                Assert.Equal(expected, exception.Message);
            });
        }

        [Fact]
        public void AllEnumValid_Error_NullList()
        {
            var exception =
                Assert.Throws<NullRequiredValueException>(() =>
                    Validate.AllEnumValid((List<EnumMock>)null));

            var expected = string.Format(ValidationErrorMessages.NullRequiredValue, DefaultLabels.List);
            Assert.Equal(expected, exception.Message);
        }
        
        [Theory]
        [InlineData("{d65273cf-8e75-4548-b371-50c6e53f102d}")]
        [InlineData("00000000-0000-0000-0000-000000000000")]
        [InlineData("foo")]
        [InlineData("")]
        [InlineData("    ")]
        [InlineData(null)]
        public void IsValidGuid_Error(string guid)
        {
            new List<string>() { "IsValidGuid_Error", null }.ForEach(label =>
            {
                var exception =
                    Assert.Throws<InvalidGuidException>(() =>
                        Validate.IsGuidValid(guid, label));

                var expected = string.Format(
                    ValidationErrorMessages.InvalidGuid,
                    label ?? DefaultLabels.Parameter);
                Assert.Equal(expected, exception.Message);
            });
        }
        
        [Theory]
        [InlineData(20000)]
        [InlineData(-750)]
        [InlineData(-721)]
        public void IsUtcOffsetValid_Error(int offset)
        {
            new List<string>() { "IsUtcOffsetValid_Error", null }.ForEach(label =>
            {
                var exception =
                    Assert.Throws<InvalidUtcOffsetException>(() =>
                        Validate.IsUtcOffsetValid(offset, label));

                var expected = string.Format(
                    ValidationErrorMessages.InvalidUtcValue,
                    label ?? DefaultLabels.UtcOffset,
                    offset,
                    Constraints.Utc.MinValue,
                    Constraints.Utc.MaxValue);
                Assert.Equal(expected, exception.Message);
            });
        }
        
        #endregion
    }
}
