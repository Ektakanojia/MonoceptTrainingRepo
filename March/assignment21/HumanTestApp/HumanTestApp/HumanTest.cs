using HumanClassLib.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanTestApp
{
    [TestClass]
    public class HumanTest
    {

        [TestMethod]
        public void ItShouldValidateHuman()
        {
            string exceptedName = "Ekta";
            Model.GenderOption exceptedGender = Model.GenderOption.FEMALE;
            int excepetedAge = 23;
            int exceptedHeight = 151;
            float exceptedWeight = 45;
            Human human = new Human("Ekta", 23, 151, 45, Model.GenderOption.FEMALE);
            Assert.AreEqual(exceptedName, human.Name);
            Assert.AreEqual(excepetedAge, human.Age);
            Assert.AreEqual(exceptedHeight, human.Height);
            Assert.AreEqual(exceptedWeight, human.Weight);
            Assert.AreEqual(exceptedGender, human.GenderOption);


        }
        //[ExpectedException(typeof(Exception))]
        [TestMethod]
        public void ItShouldCalculateTheBMIIfBothHeightAndWeightIsPostive()
        {
            double exceptedBMI = 0.0017;
            Human human = new Human("Ekta", 23, 151, 40, Model.GenderOption.FEMALE);
             double  actualBMI = human.BodyMassIndex(151, 40);
            Assert.AreEqual(exceptedBMI, actualBMI,0.0001f);

        }
        [ExpectedException(typeof(Exception))]
        [TestMethod]
        public void ItShouldThrowExceptionIfAnyOneOfHeightAndWeightIsZero()
        {
            double exceptedBMI = 0;
            Human human = new Human("Ekta", 23, 0, 0, Model.GenderOption.FEMALE);
            double actualBMI = human.BodyMassIndex(0, 0);
            Assert.AreEqual(exceptedBMI, actualBMI);

        }
    }
}
