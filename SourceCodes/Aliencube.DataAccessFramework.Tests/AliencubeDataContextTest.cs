using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using DataAccessFramework.Configuration;
using DataAccessFramework.Configuration.Interfaces;
using NUnit.Framework;

namespace Aliencube.DataAccessFramework.Tests
{
    [TestFixture]
    public class AliencubeDataContextTest
    {
        private IConnectionBuilder _builder;
        private AliencubeDataContext _context;
        #region SetUp / TearDown

        [TestFixtureSetUp]
        public void Init()
        {
            var settings = ConfigurationManager.GetSection("connectionSettings") as ConnectionSettings;
            this._builder = new ConnectionBuilder(settings);
            this._context = new AliencubeDataContext(this._builder.GetConnectionString(0));
        }

        [TestFixtureTearDown]
        public void Dispose()
        {
            this._builder.Dispose();
            this._context.Dispose();
        }

        #endregion

        #region Tests

        [Test]
        public void Test()
        {
        }

        #endregion
    }
}
