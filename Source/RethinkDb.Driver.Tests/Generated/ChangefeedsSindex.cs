




//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Ast;
using NUnit.Framework;
using RethinkDb.Driver.Tests;
using static RethinkDb.Driver.Tests.TestingCommon;

namespace RethinkDb.Driver.Test.Generated {

    // Test basic changefeed operations

    [TestFixture]
    public class ChangefeedsSindex : GeneratedTest {

        public ChangefeedsSindex (){
                tableVars.Add( "tbl" );
        }


            public static Table tbl = r.db(DbName).table("tbl");


        [Test]
        public void YamlTest(){


        }
    }
}
