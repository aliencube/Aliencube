using DataAccessFramework.Configuration;
using DataAccessFramework.Configuration.Interfaces;
using NSubstitute;
using NUnit.Framework;
using System.Configuration;
using System.Data;
using System.Linq;

namespace Aliencube.DataAccessFramework.Tests
{
    [TestFixture]
    public class AliencubeDataContextTest
    {
        private IConnectionSettings _settings;
        private IConnectionBuilder _builder;
        private AliencubeDataContext _context;

        #region SetUp / TearDown

        [TestFixtureSetUp]
        public void Init()
        {
            this._settings = ConfigurationManager.GetSection("connectionSettings") as ConnectionSettings;
            this._builder = Substitute.For<ConnectionBuilder>(this._settings);
            this._context = Substitute.For<AliencubeDataContext>(this._builder.GetConnectionString("AliencubeDataContext"));
        }

        [TestFixtureTearDown]
        public void Dispose()
        {
            this._context.Dispose();
            this._builder.Dispose();
            this._settings.Dispose();
        }

        #endregion SetUp / TearDown

        #region Connection

        [Test]
        public void GetContext_ContextOpen()
        {
            Assert.IsTrue(this._context.Database.Exists());

            this._context.Database.Connection.Open();
            Assert.IsTrue(this._context.Database.Connection.State == ConnectionState.Open);
            this._context.Database.Connection.Close();
        }

        #endregion Connection

        #region Select

        [Test]
        [TestCase(0, "System", true)]
        public void GetUser_SendUserId_UserSelected(int userId, string username, bool expected)
        {
            var user = this._context.Users.Single(p => p.UserId == userId);
            Assert.AreEqual(expected, username.ToLower() == user.Username.ToLower());
        }

        [Test]
        [TestCase(0, "System", true)]
        public void GetRole_SendRoleId_RoleSelected(int roleId, string roleName, bool expected)
        {
            var role = this._context.Roles.Single(p => p.RoleId == roleId);
            Assert.AreEqual(expected, roleName.ToLower() == role.RoleName.ToLower());
        }

        #endregion Select
    }
}