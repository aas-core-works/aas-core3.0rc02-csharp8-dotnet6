/*
 * This code has been automatically generated by testgen.
 * Do NOT edit or append.
 */

using Aas = AasCore.Aas3_0_RC02;  // renamed

using System.Linq;  // can't alias
using NUnit.Framework;  // can't alias

namespace AasCore.Aas3_0_RC02.Tests
{
    public class TestVerificationOfEnums
    {
        [Test]
        public void Test_ModelingKind_valid()
        {
            var errors = Aas.Verification.VerifyModelingKind(
                Aas.ModelingKind.Template).ToList();

            Assert.IsEmpty(errors);
        }  // void Test_ModelingKind_valid

        [Test]
        public void Test_ModelingKind_invalid()
        {
            int valueAsInt = -1;
            Aas.ModelingKind value = (Aas.ModelingKind)valueAsInt;

            var errors = Aas.Verification.VerifyModelingKind(
                value).ToList();

            Assert.AreEqual(1, errors.Count);
            Assert.AreEqual("Invalid ModelingKind: -1", errors[0].Cause);
        }  // void Test_ModelingKind_invalid

        [Test]
        public void Test_QualifierKind_valid()
        {
            var errors = Aas.Verification.VerifyQualifierKind(
                Aas.QualifierKind.ValueQualifier).ToList();

            Assert.IsEmpty(errors);
        }  // void Test_QualifierKind_valid

        [Test]
        public void Test_QualifierKind_invalid()
        {
            int valueAsInt = -1;
            Aas.QualifierKind value = (Aas.QualifierKind)valueAsInt;

            var errors = Aas.Verification.VerifyQualifierKind(
                value).ToList();

            Assert.AreEqual(1, errors.Count);
            Assert.AreEqual("Invalid QualifierKind: -1", errors[0].Cause);
        }  // void Test_QualifierKind_invalid

        [Test]
        public void Test_AssetKind_valid()
        {
            var errors = Aas.Verification.VerifyAssetKind(
                Aas.AssetKind.Type).ToList();

            Assert.IsEmpty(errors);
        }  // void Test_AssetKind_valid

        [Test]
        public void Test_AssetKind_invalid()
        {
            int valueAsInt = -1;
            Aas.AssetKind value = (Aas.AssetKind)valueAsInt;

            var errors = Aas.Verification.VerifyAssetKind(
                value).ToList();

            Assert.AreEqual(1, errors.Count);
            Assert.AreEqual("Invalid AssetKind: -1", errors[0].Cause);
        }  // void Test_AssetKind_invalid

        [Test]
        public void Test_AasSubmodelElements_valid()
        {
            var errors = Aas.Verification.VerifyAasSubmodelElements(
                Aas.AasSubmodelElements.AnnotatedRelationshipElement).ToList();

            Assert.IsEmpty(errors);
        }  // void Test_AasSubmodelElements_valid

        [Test]
        public void Test_AasSubmodelElements_invalid()
        {
            int valueAsInt = -1;
            Aas.AasSubmodelElements value = (Aas.AasSubmodelElements)valueAsInt;

            var errors = Aas.Verification.VerifyAasSubmodelElements(
                value).ToList();

            Assert.AreEqual(1, errors.Count);
            Assert.AreEqual("Invalid AasSubmodelElements: -1", errors[0].Cause);
        }  // void Test_AasSubmodelElements_invalid

        [Test]
        public void Test_EntityType_valid()
        {
            var errors = Aas.Verification.VerifyEntityType(
                Aas.EntityType.CoManagedEntity).ToList();

            Assert.IsEmpty(errors);
        }  // void Test_EntityType_valid

        [Test]
        public void Test_EntityType_invalid()
        {
            int valueAsInt = -1;
            Aas.EntityType value = (Aas.EntityType)valueAsInt;

            var errors = Aas.Verification.VerifyEntityType(
                value).ToList();

            Assert.AreEqual(1, errors.Count);
            Assert.AreEqual("Invalid EntityType: -1", errors[0].Cause);
        }  // void Test_EntityType_invalid

        [Test]
        public void Test_Direction_valid()
        {
            var errors = Aas.Verification.VerifyDirection(
                Aas.Direction.Input).ToList();

            Assert.IsEmpty(errors);
        }  // void Test_Direction_valid

        [Test]
        public void Test_Direction_invalid()
        {
            int valueAsInt = -1;
            Aas.Direction value = (Aas.Direction)valueAsInt;

            var errors = Aas.Verification.VerifyDirection(
                value).ToList();

            Assert.AreEqual(1, errors.Count);
            Assert.AreEqual("Invalid Direction: -1", errors[0].Cause);
        }  // void Test_Direction_invalid

        [Test]
        public void Test_StateOfEvent_valid()
        {
            var errors = Aas.Verification.VerifyStateOfEvent(
                Aas.StateOfEvent.On).ToList();

            Assert.IsEmpty(errors);
        }  // void Test_StateOfEvent_valid

        [Test]
        public void Test_StateOfEvent_invalid()
        {
            int valueAsInt = -1;
            Aas.StateOfEvent value = (Aas.StateOfEvent)valueAsInt;

            var errors = Aas.Verification.VerifyStateOfEvent(
                value).ToList();

            Assert.AreEqual(1, errors.Count);
            Assert.AreEqual("Invalid StateOfEvent: -1", errors[0].Cause);
        }  // void Test_StateOfEvent_invalid

        [Test]
        public void Test_ReferenceTypes_valid()
        {
            var errors = Aas.Verification.VerifyReferenceTypes(
                Aas.ReferenceTypes.GlobalReference).ToList();

            Assert.IsEmpty(errors);
        }  // void Test_ReferenceTypes_valid

        [Test]
        public void Test_ReferenceTypes_invalid()
        {
            int valueAsInt = -1;
            Aas.ReferenceTypes value = (Aas.ReferenceTypes)valueAsInt;

            var errors = Aas.Verification.VerifyReferenceTypes(
                value).ToList();

            Assert.AreEqual(1, errors.Count);
            Assert.AreEqual("Invalid ReferenceTypes: -1", errors[0].Cause);
        }  // void Test_ReferenceTypes_invalid

        [Test]
        public void Test_KeyTypes_valid()
        {
            var errors = Aas.Verification.VerifyKeyTypes(
                Aas.KeyTypes.FragmentReference).ToList();

            Assert.IsEmpty(errors);
        }  // void Test_KeyTypes_valid

        [Test]
        public void Test_KeyTypes_invalid()
        {
            int valueAsInt = -1;
            Aas.KeyTypes value = (Aas.KeyTypes)valueAsInt;

            var errors = Aas.Verification.VerifyKeyTypes(
                value).ToList();

            Assert.AreEqual(1, errors.Count);
            Assert.AreEqual("Invalid KeyTypes: -1", errors[0].Cause);
        }  // void Test_KeyTypes_invalid

        [Test]
        public void Test_DataTypeDefXsd_valid()
        {
            var errors = Aas.Verification.VerifyDataTypeDefXsd(
                Aas.DataTypeDefXsd.AnyUri).ToList();

            Assert.IsEmpty(errors);
        }  // void Test_DataTypeDefXsd_valid

        [Test]
        public void Test_DataTypeDefXsd_invalid()
        {
            int valueAsInt = -1;
            Aas.DataTypeDefXsd value = (Aas.DataTypeDefXsd)valueAsInt;

            var errors = Aas.Verification.VerifyDataTypeDefXsd(
                value).ToList();

            Assert.AreEqual(1, errors.Count);
            Assert.AreEqual("Invalid DataTypeDefXsd: -1", errors[0].Cause);
        }  // void Test_DataTypeDefXsd_invalid
    }  // class TestVerificationOfEnums
}  // namespace AasCore.Aas3_0_RC02.Tests

/*
 * This code has been automatically generated by testgen.
 * Do NOT edit or append.
 */
