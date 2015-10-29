




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

    // Tests deletes of selections

    [TestFixture]
    public class MutationDelete : GeneratedTest {

        public MutationDelete (){
                tableVars.Add( "tbl" );
        }


            public static Table tbl = r.db(DbName).table("tbl");


        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, mutation/delete.yaml, #7
                 /* ExpectedOriginal: ({'deleted':0,'replaced':0,'unchanged':0,'errors':0,'skipped':0,'inserted':100}) */
                 var expected_ = r.hashMap("deleted", 0L).with("replaced", 0L).with("unchanged", 0L).with("errors", 0L).with("skipped", 0L).with("inserted", 100L);
                 
                 /* Original: tbl.insert([{'id':i} for i in xrange(100)]) */
                 var obtained = runOrCatch( tbl.insert(EnumerableLRange(0, 100L).Select(i => r.hashMap("id", i)).ToList()) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/delete.yaml, #19
                 /* ExpectedOriginal: 100 */
                 var expected_ = 100L;
                 
                 /* Original: tbl.count() */
                 var obtained = runOrCatch( tbl.count() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/delete.yaml, #24
                 /* ExpectedOriginal: ({'deleted':1,'replaced':0,'unchanged':0,'errors':0,'skipped':0,'inserted':0}) */
                 var expected_ = r.hashMap("deleted", 1L).with("replaced", 0L).with("unchanged", 0L).with("errors", 0L).with("skipped", 0L).with("inserted", 0L);
                 
                 /* Original: tbl.get(12).delete() */
                 var obtained = runOrCatch( tbl.get(12L).delete() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/delete.yaml, #31
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Durability option `wrong` unrecognized (options are "hard" and "soft").', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Durability option `wrong` unrecognized (options are \"hard\" and \"soft\").", r.array(0L));
                 
                 /* Original: tbl.skip(50).delete(durability='wrong') */
                 var obtained = runOrCatch( tbl.skip(50L).delete().optArg("durability", "wrong") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/delete.yaml, #38
                 /* ExpectedOriginal: ({'deleted':49,'replaced':0,'unchanged':0,'errors':0,'skipped':0,'inserted':0}) */
                 var expected_ = r.hashMap("deleted", 49L).with("replaced", 0L).with("unchanged", 0L).with("errors", 0L).with("skipped", 0L).with("inserted", 0L);
                 
                 /* Original: tbl.skip(50).delete(durability='soft') */
                 var obtained = runOrCatch( tbl.skip(50L).delete().optArg("durability", "soft") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/delete.yaml, #45
                 /* ExpectedOriginal: ({'deleted':50,'replaced':0,'unchanged':0,'errors':0,'skipped':0,'inserted':0}) */
                 var expected_ = r.hashMap("deleted", 50L).with("replaced", 0L).with("unchanged", 0L).with("errors", 0L).with("skipped", 0L).with("inserted", 0L);
                 
                 /* Original: tbl.delete(durability='hard') */
                 var obtained = runOrCatch( tbl.delete().optArg("durability", "hard") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/delete.yaml, #49
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Expected type SELECTION but found DATUM:', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type SELECTION but found DATUM:", r.array(0L));
                 
                 /* Original: r.expr([1, 2]).delete() */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L)).delete() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             

        }
    }
}
