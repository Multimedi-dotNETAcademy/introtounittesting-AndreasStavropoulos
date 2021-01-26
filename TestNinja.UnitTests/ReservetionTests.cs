using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    public class ReservetionTests
    {
        private Reservation _reservation;
        private User _user;

        [SetUp]
        public void SetUp()
        {
            _reservation = new Reservation();
            _user = new User();
        }

        [Test]
        public void CanBeCancelledBy_WhenCalled_ReturnsTrueIfUserIsAdmin()
        {
            _user.IsAdmin = true;

            //Act
            var result = _reservation.CanBeCancelledBy(_user);

            //Assert
            Assert.AreEqual(true, result);
        }

        [Test]
        public void CanBeCancelledBy_WhenCalled_ReturnsTrueIfUserIsUser()
        {
            _user.IsAdmin = false;
            _reservation.MadeBy = _user;

            //Act
            var result = _reservation.CanBeCancelledBy(_reservation.MadeBy);

            //Assert
            Assert.AreEqual(true, result);
        }
        [Test]
        public void CanBeCancelledBy_WhenCalled_ReturnsFalseIfUserIsNotAdminOrUserMadeBy()
        {
            //Act
            var result = _reservation.CanBeCancelledBy(_user);

            //Assert
            Assert.AreEqual(false, result);
        }
    }
}
