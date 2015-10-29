




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

    // Tests insertion into tables

    [TestFixture]
    public class MutationInsert : GeneratedTest {

        public MutationInsert (){
                tableVars.Add( "tbl" );
        }


            public static Table tbl = r.db(DbName).table("tbl");


        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #6
                 /* ExpectedOriginal: partial({'tables_created':1}) */
                 var expected_ = partial(r.hashMap("tables_created", 1L));
                 
                 /* Original: r.db('test').table_create('test2') */
                 var obtained = runOrCatch( r.db("test").tableCreate("test2") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             
             //JavaDef, mutation/insert.yaml, #9
             //Original: tbl2 = r.db('test').table('test2')
             
                 var tbl2 = (Table) (r.db("test").table("test2"));
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #12
                 /* ExpectedOriginal: {'deleted':0,'replaced':0,'unchanged':0,'errors':0,'skipped':0,'inserted':1} */
                 var expected_ = r.hashMap("deleted", 0L).with("replaced", 0L).with("unchanged", 0L).with("errors", 0L).with("skipped", 0L).with("inserted", 1L);
                 
                 /* Original: tbl.insert({'id':0,'a':0}) */
                 var obtained = runOrCatch( tbl.insert(r.hashMap("id", 0L).with("a", 0L)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #14
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: tbl.count() */
                 var obtained = runOrCatch( tbl.count() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #18
                 /* ExpectedOriginal: {'deleted':0,'replaced':0,'unchanged':0,'errors':0,'skipped':0,'inserted':1} */
                 var expected_ = r.hashMap("deleted", 0L).with("replaced", 0L).with("unchanged", 0L).with("errors", 0L).with("skipped", 0L).with("inserted", 1L);
                 
                 /* Original: tbl.insert({'id':1, 'a':1}, durability='hard') */
                 var obtained = runOrCatch( tbl.insert(r.hashMap("id", 1L).with("a", 1L)).optArg("durability", "hard") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #22
                 /* ExpectedOriginal: 2 */
                 var expected_ = 2L;
                 
                 /* Original: tbl.count() */
                 var obtained = runOrCatch( tbl.count() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #26
                 /* ExpectedOriginal: {'deleted':0,'replaced':0,'unchanged':0,'errors':0,'skipped':0,'inserted':1} */
                 var expected_ = r.hashMap("deleted", 0L).with("replaced", 0L).with("unchanged", 0L).with("errors", 0L).with("skipped", 0L).with("inserted", 1L);
                 
                 /* Original: tbl.insert({'id':2, 'a':2}, durability='soft') */
                 var obtained = runOrCatch( tbl.insert(r.hashMap("id", 2L).with("a", 2L)).optArg("durability", "soft") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #30
                 /* ExpectedOriginal: 3 */
                 var expected_ = 3L;
                 
                 /* Original: tbl.count() */
                 var obtained = runOrCatch( tbl.count() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #34
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Durability option `wrong` unrecognized (options are "hard" and "soft").', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Durability option `wrong` unrecognized (options are \"hard\" and \"soft\").", r.array(0L));
                 
                 /* Original: tbl.insert({'id':3, 'a':3}, durability='wrong') */
                 var obtained = runOrCatch( tbl.insert(r.hashMap("id", 3L).with("a", 3L)).optArg("durability", "wrong") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #38
                 /* ExpectedOriginal: 3 */
                 var expected_ = 3L;
                 
                 /* Original: tbl.count() */
                 var obtained = runOrCatch( tbl.count() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #42
                 /* ExpectedOriginal: {'deleted':1,'replaced':0,'unchanged':0,'errors':0,'skipped':0,'inserted':0} */
                 var expected_ = r.hashMap("deleted", 1L).with("replaced", 0L).with("unchanged", 0L).with("errors", 0L).with("skipped", 0L).with("inserted", 0L);
                 
                 /* Original: tbl.get(2).delete() */
                 var obtained = runOrCatch( tbl.get(2L).delete() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #46
                 /* ExpectedOriginal: {'deleted':0,'replaced':0,'unchanged':0,'errors':0,'skipped':0,'inserted':2} */
                 var expected_ = r.hashMap("deleted", 0L).with("replaced", 0L).with("unchanged", 0L).with("errors", 0L).with("skipped", 0L).with("inserted", 2L);
                 
                 /* Original: tbl.insert([{'id':2,'a':2}, {'id':3,'a':3}]) */
                 var obtained = runOrCatch( tbl.insert(r.array(r.hashMap("id", 2L).with("a", 2L), r.hashMap("id", 3L).with("a", 3L))) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #50
                 /* ExpectedOriginal: {'deleted':0,'replaced':0,'unchanged':0,'errors':0,'skipped':0,'inserted':4} */
                 var expected_ = r.hashMap("deleted", 0L).with("replaced", 0L).with("unchanged", 0L).with("errors", 0L).with("skipped", 0L).with("inserted", 4L);
                 
                 /* Original: tbl2.insert(tbl) */
                 var obtained = runOrCatch( tbl2.insert(tbl) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #54
                 /* ExpectedOriginal: {'first_error':"Duplicate primary key `id`:\n{\n\t\"a\":\t2,\n\t\"id\":\t2\n}\n{\n\t\"b\":\t20,\n\t\"id\":\t2\n}",'deleted':0,'replaced':0,'unchanged':0,'errors':1,'skipped':0,'inserted':0} */
                 var expected_ = r.hashMap("first_error", "Duplicate primary key `id`:\n{\n\t\"a\":\t2,\n\t\"id\":\t2\n}\n{\n\t\"b\":\t20,\n\t\"id\":\t2\n}").with("deleted", 0L).with("replaced", 0L).with("unchanged", 0L).with("errors", 1L).with("skipped", 0L).with("inserted", 0L);
                 
                 /* Original: tbl.insert({'id':2,'b':20}) */
                 var obtained = runOrCatch( tbl.insert(r.hashMap("id", 2L).with("b", 20L)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #58
                 /* ExpectedOriginal: {'first_error':"Duplicate primary key `id`:\n{\n\t\"a\":\t2,\n\t\"id\":\t2\n}\n{\n\t\"b\":\t20,\n\t\"id\":\t2\n}",'deleted':0,'replaced':0,'unchanged':0,'errors':1,'skipped':0,'inserted':0} */
                 var expected_ = r.hashMap("first_error", "Duplicate primary key `id`:\n{\n\t\"a\":\t2,\n\t\"id\":\t2\n}\n{\n\t\"b\":\t20,\n\t\"id\":\t2\n}").with("deleted", 0L).with("replaced", 0L).with("unchanged", 0L).with("errors", 1L).with("skipped", 0L).with("inserted", 0L);
                 
                 /* Original: tbl.insert({'id':2,'b':20}, conflict='error') */
                 var obtained = runOrCatch( tbl.insert(r.hashMap("id", 2L).with("b", 20L)).optArg("conflict", "error") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #64
                 /* ExpectedOriginal: {'deleted':0,'replaced':0,'unchanged':0,'errors':0,'skipped':0,'inserted':1} */
                 var expected_ = r.hashMap("deleted", 0L).with("replaced", 0L).with("unchanged", 0L).with("errors", 0L).with("skipped", 0L).with("inserted", 1L);
                 
                 /* Original: tbl.insert({'id':15,'b':20}, conflict='error') */
                 var obtained = runOrCatch( tbl.insert(r.hashMap("id", 15L).with("b", 20L)).optArg("conflict", "error") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #69
                 /* ExpectedOriginal: {'id':15,'b':20} */
                 var expected_ = r.hashMap("id", 15L).with("b", 20L);
                 
                 /* Original: tbl.get(15) */
                 var obtained = runOrCatch( tbl.get(15L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #73
                 /* ExpectedOriginal: {'deleted':0,'replaced':1,'unchanged':0,'errors':0,'skipped':0,'inserted':0} */
                 var expected_ = r.hashMap("deleted", 0L).with("replaced", 1L).with("unchanged", 0L).with("errors", 0L).with("skipped", 0L).with("inserted", 0L);
                 
                 /* Original: tbl.insert({'id':2,'b':20}, conflict='replace') */
                 var obtained = runOrCatch( tbl.insert(r.hashMap("id", 2L).with("b", 20L)).optArg("conflict", "replace") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #78
                 /* ExpectedOriginal: {'id':2,'b':20} */
                 var expected_ = r.hashMap("id", 2L).with("b", 20L);
                 
                 /* Original: tbl.get(2) */
                 var obtained = runOrCatch( tbl.get(2L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #82
                 /* ExpectedOriginal: {'deleted':0,'replaced':0,'unchanged':0,'errors':0,'skipped':0,'inserted':1} */
                 var expected_ = r.hashMap("deleted", 0L).with("replaced", 0L).with("unchanged", 0L).with("errors", 0L).with("skipped", 0L).with("inserted", 1L);
                 
                 /* Original: tbl.insert({'id':20,'b':20}, conflict='replace') */
                 var obtained = runOrCatch( tbl.insert(r.hashMap("id", 20L).with("b", 20L)).optArg("conflict", "replace") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #87
                 /* ExpectedOriginal: {'id':20,'b':20} */
                 var expected_ = r.hashMap("id", 20L).with("b", 20L);
                 
                 /* Original: tbl.get(20) */
                 var obtained = runOrCatch( tbl.get(20L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #91
                 /* ExpectedOriginal: {'deleted':0,'replaced':1,'unchanged':0,'errors':0,'skipped':0,'inserted':0} */
                 var expected_ = r.hashMap("deleted", 0L).with("replaced", 1L).with("unchanged", 0L).with("errors", 0L).with("skipped", 0L).with("inserted", 0L);
                 
                 /* Original: tbl.insert({'id':2,'c':30}, conflict='update') */
                 var obtained = runOrCatch( tbl.insert(r.hashMap("id", 2L).with("c", 30L)).optArg("conflict", "update") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #96
                 /* ExpectedOriginal: {'id':2, 'b':20, 'c':30} */
                 var expected_ = r.hashMap("id", 2L).with("b", 20L).with("c", 30L);
                 
                 /* Original: tbl.get(2) */
                 var obtained = runOrCatch( tbl.get(2L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #100
                 /* ExpectedOriginal: {'deleted':0,'replaced':0,'unchanged':0,'errors':0,'skipped':0,'inserted':1} */
                 var expected_ = r.hashMap("deleted", 0L).with("replaced", 0L).with("unchanged", 0L).with("errors", 0L).with("skipped", 0L).with("inserted", 1L);
                 
                 /* Original: tbl.insert({'id':30,'b':20}, conflict='update') */
                 var obtained = runOrCatch( tbl.insert(r.hashMap("id", 30L).with("b", 20L)).optArg("conflict", "update") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #105
                 /* ExpectedOriginal: {'id':30,'b':20} */
                 var expected_ = r.hashMap("id", 30L).with("b", 20L);
                 
                 /* Original: tbl.get(30) */
                 var obtained = runOrCatch( tbl.get(30L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #109
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Conflict option `wrong` unrecognized (options are "error", "replace" and "update").', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Conflict option `wrong` unrecognized (options are \"error\", \"replace\" and \"update\").", r.array(0L));
                 
                 /* Original: tbl.insert({'id':3, 'a':3}, conflict='wrong') */
                 var obtained = runOrCatch( tbl.insert(r.hashMap("id", 3L).with("a", 3L)).optArg("conflict", "wrong") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             
             //JavaDef, mutation/insert.yaml, #120
             //Original: tblpkey = r.db('test').table('testpkey')
             
                 var tblpkey = (Table) (r.db("test").table("testpkey"));
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #115
                 /* ExpectedOriginal: partial({'tables_created':1}) */
                 var expected_ = partial(r.hashMap("tables_created", 1L));
                 
                 /* Original: r.db('test').table_create('testpkey', primary_key='foo') */
                 var obtained = runOrCatch( r.db("test").tableCreate("testpkey").optArg("primary_key", "foo") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #122
                 /* ExpectedOriginal: {'deleted':0,'replaced':0,'generated_keys':arrlen(1,uuid()),'unchanged':0,'errors':0,'skipped':0,'inserted':1} */
                 var expected_ = r.hashMap("deleted", 0L).with("replaced", 0L).with("generated_keys", arrlen(1L, uuid())).with("unchanged", 0L).with("errors", 0L).with("skipped", 0L).with("inserted", 1L);
                 
                 /* Original: tblpkey.insert({}) */
                 var obtained = runOrCatch( tblpkey.insert(r.hashMap()) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #125
                 /* ExpectedOriginal: [{'foo':uuid()}] */
                 var expected_ = r.array(r.hashMap("foo", uuid()));
                 
                 /* Original: tblpkey */
                 var obtained = runOrCatch( tblpkey ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #129
                 /* ExpectedOriginal: {'deleted':0,'replaced':0,'generated_keys':arrlen(1,uuid()),'unchanged':0,'errors':0,'skipped':0,'inserted':1} */
                 var expected_ = r.hashMap("deleted", 0L).with("replaced", 0L).with("generated_keys", arrlen(1L, uuid())).with("unchanged", 0L).with("errors", 0L).with("skipped", 0L).with("inserted", 1L);
                 
                 /* Original: tblpkey.insert({'b':20}, conflict='replace') */
                 var obtained = runOrCatch( tblpkey.insert(r.hashMap("b", 20L)).optArg("conflict", "replace") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #135
                 /* ExpectedOriginal: {'deleted':0,'replaced':0,'generated_keys':arrlen(1,uuid()),'unchanged':0,'errors':0,'skipped':0,'inserted':1} */
                 var expected_ = r.hashMap("deleted", 0L).with("replaced", 0L).with("generated_keys", arrlen(1L, uuid())).with("unchanged", 0L).with("errors", 0L).with("skipped", 0L).with("inserted", 1L);
                 
                 /* Original: tblpkey.insert({'b':20}, conflict='update') */
                 var obtained = runOrCatch( tblpkey.insert(r.hashMap("b", 20L)).optArg("conflict", "update") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #140
                 /* ExpectedOriginal: partial({'tables_dropped':1}) */
                 var expected_ = partial(r.hashMap("tables_dropped", 1L));
                 
                 /* Original: r.db('test').table_drop('testpkey') */
                 var obtained = runOrCatch( r.db("test").tableDrop("testpkey") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #144
                 /* ExpectedOriginal: {'deleted':0,'replaced':0,'unchanged':0,'errors':0,'skipped':0,'inserted':7} */
                 var expected_ = r.hashMap("deleted", 0L).with("replaced", 0L).with("unchanged", 0L).with("errors", 0L).with("skipped", 0L).with("inserted", 7L);
                 
                 /* Original: tbl.for_each(lambda  row:          tbl2.insert(row.merge({'id':row['id']  +  100 }))   ) */
                 var obtained = runOrCatch( tbl.forEach(row => tbl2.insert(row.merge(r.hashMap("id", row.bracket("id").add(100L))))) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #150
                 /* ExpectedOriginal: partial({'errors':1,'first_error':'`r.minval` and `r.maxval` cannot be written to disk.'}) */
                 var expected_ = partial(r.hashMap("errors", 1L).with("first_error", "`r.minval` and `r.maxval` cannot be written to disk."));
                 
                 /* Original: tbl.insert({'value':r.minval}) */
                 var obtained = runOrCatch( tbl.insert(r.hashMap("value", r.minval())) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #154
                 /* ExpectedOriginal: partial({'errors':1,'first_error':'`r.minval` and `r.maxval` cannot be written to disk.'}) */
                 var expected_ = partial(r.hashMap("errors", 1L).with("first_error", "`r.minval` and `r.maxval` cannot be written to disk."));
                 
                 /* Original: tbl.insert({'value':r.maxval}) */
                 var obtained = runOrCatch( tbl.insert(r.hashMap("value", r.maxval())) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #159
                 /* ExpectedOriginal: err('ReqlQueryLogicError','Cannot convert `r.minval` to JSON.') */
                 var expected_ = err("ReqlQueryLogicError", "Cannot convert `r.minval` to JSON.");
                 
                 /* Original: r.minval */
                 var obtained = runOrCatch( r.minval() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #162
                 /* ExpectedOriginal: err('ReqlQueryLogicError','Cannot convert `r.maxval` to JSON.') */
                 var expected_ = err("ReqlQueryLogicError", "Cannot convert `r.maxval` to JSON.");
                 
                 /* Original: r.maxval */
                 var obtained = runOrCatch( r.maxval() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, mutation/insert.yaml, #166
                 /* ExpectedOriginal: partial({'tables_dropped':1}) */
                 var expected_ = partial(r.hashMap("tables_dropped", 1L));
                 
                 /* Original: r.db('test').table_drop('test2') */
                 var obtained = runOrCatch( r.db("test").tableDrop("test2") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             

        }
    }
}
