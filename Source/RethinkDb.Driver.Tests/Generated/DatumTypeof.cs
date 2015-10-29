




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

    // These tests test the type of command

    [TestFixture]
    public class DatumTypeof : GeneratedTest {

        public DatumTypeof (){
        }




        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, datum/typeof.yaml, #5
                 /* ExpectedOriginal: NULL */
                 var expected_ = "NULL";
                 
                 /* Original: r.expr(null).type_of() */
                 var obtained = runOrCatch( r.expr((ReqlExpr) null).typeOf() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, datum/typeof.yaml, #9
                 /* ExpectedOriginal: NULL */
                 var expected_ = "NULL";
                 
                 /* Original: r.type_of(null) */
                 var obtained = runOrCatch( r.typeOf((ReqlExpr) null) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             

        }
    }
}
