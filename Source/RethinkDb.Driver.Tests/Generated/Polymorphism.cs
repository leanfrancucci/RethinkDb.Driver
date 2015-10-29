




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

    // Tests that manipulation data in tables

    [TestFixture]
    public class Polymorphism : GeneratedTest {

        public Polymorphism (){
                tableVars.Add( "tbl" );
        }


            public static Table tbl = r.db(DbName).table("tbl");


        [Test]
        public void YamlTest(){

             
             //JavaDef, polymorphism.yaml, #5
             //Original: obj = r.expr({'id':0,'a':0})
             
                 var obj = (MakeObj) (r.expr(r.hashMap("id", 0L).with("a", 0L)));
             
             TestCounter++;
             
             {
                 //JavaQuery, polymorphism.yaml, #7
                 /* ExpectedOriginal: ({'deleted':0,'replaced':0,'unchanged':0,'errors':0,'skipped':0,'inserted':3}) */
                 var expected_ = r.hashMap("deleted", 0L).with("replaced", 0L).with("unchanged", 0L).with("errors", 0L).with("skipped", 0L).with("inserted", 3L);
                 
                 /* Original: tbl.insert([{'id':i, 'a':i} for i in xrange(3)]) */
                 var obtained = runOrCatch( tbl.insert(EnumerableLRange(0, 3L).Select(i => r.hashMap("id", i).with("a", i)).ToList()) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, polymorphism.yaml, #21
                 /* ExpectedOriginal: ({'id':0,'c':1,'a':0}) */
                 var expected_ = r.hashMap("id", 0L).with("c", 1L).with("a", 0L);
                 
                 /* Original: tbl.merge({'c':1}).nth(0) */
                 var obtained = runOrCatch( tbl.merge(r.hashMap("c", 1L)).nth(0L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, polymorphism.yaml, #22
                 /* ExpectedOriginal: ({'id':0,'c':1,'a':0}) */
                 var expected_ = r.hashMap("id", 0L).with("c", 1L).with("a", 0L);
                 
                 /* Original: obj.merge({'c':1}) */
                 var obtained = runOrCatch( obj.merge(r.hashMap("c", 1L)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, polymorphism.yaml, #26
                 /* ExpectedOriginal: ({'id':0}) */
                 var expected_ = r.hashMap("id", 0L);
                 
                 /* Original: tbl.without('a').nth(0) */
                 var obtained = runOrCatch( tbl.without("a").nth(0L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, polymorphism.yaml, #27
                 /* ExpectedOriginal: ({'id':0}) */
                 var expected_ = r.hashMap("id", 0L);
                 
                 /* Original: obj.without('a') */
                 var obtained = runOrCatch( obj.without("a") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, polymorphism.yaml, #31
                 /* ExpectedOriginal: ({'a':0}) */
                 var expected_ = r.hashMap("a", 0L);
                 
                 /* Original: tbl.pluck('a').nth(0) */
                 var obtained = runOrCatch( tbl.pluck("a").nth(0L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, polymorphism.yaml, #32
                 /* ExpectedOriginal: ({'a':0}) */
                 var expected_ = r.hashMap("a", 0L);
                 
                 /* Original: obj.pluck('a') */
                 var obtained = runOrCatch( obj.pluck("a") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             

        }
    }
}
