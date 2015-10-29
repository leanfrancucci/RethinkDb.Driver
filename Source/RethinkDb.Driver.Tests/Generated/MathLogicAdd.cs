




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

    // Tests for basic usage of the add operation

    [TestFixture]
    public class MathLogicAdd : GeneratedTest {

        public MathLogicAdd (){
        }




        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, math_logic/add.yaml, #3
                 /* ExpectedOriginal: 2 */
                 var expected_ = 2L;
                 
                 /* Original: r.add(1, 1) */
                 var obtained = runOrCatch( r.add(1L, 1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/add.yaml, #8
                 /* ExpectedOriginal: 2 */
                 var expected_ = 2L;
                 
                 /* Original: r.expr(1) + 1 */
                 var obtained = runOrCatch( r.expr(1L).add(1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/add.yaml, #9
                 /* ExpectedOriginal: 2 */
                 var expected_ = 2L;
                 
                 /* Original: 1 + r.expr(1) */
                 var obtained = runOrCatch( r.add(1L, r.expr(1L)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/add.yaml, #10
                 /* ExpectedOriginal: 2 */
                 var expected_ = 2L;
                 
                 /* Original: r.expr(1).add(1) */
                 var obtained = runOrCatch( r.expr(1L).add(1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/add.yaml, #16
                 /* ExpectedOriginal: 0 */
                 var expected_ = 0L;
                 
                 /* Original: r.expr(-1) + 1 */
                 var obtained = runOrCatch( r.expr(-1L).add(1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/add.yaml, #21
                 /* ExpectedOriginal: 10.25 */
                 var expected_ = 10.25;
                 
                 /* Original: r.expr(1.75) + 8.5 */
                 var obtained = runOrCatch( r.expr(1.75).add(8.5) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/add.yaml, #27
                 /* ExpectedOriginal:  */
                 var expected_ = "";
                 
                 /* Original: r.expr('') + '' */
                 var obtained = runOrCatch( r.expr("").add("") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/add.yaml, #32
                 /* ExpectedOriginal: abcdef */
                 var expected_ = "abcdef";
                 
                 /* Original: r.expr('abc') + 'def' */
                 var obtained = runOrCatch( r.expr("abc").add("def") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/add.yaml, #38
                 /* ExpectedOriginal: [1,2,3,4,5,6,7,8] */
                 var expected_ = r.array(1L, 2L, 3L, 4L, 5L, 6L, 7L, 8L);
                 
                 /* Original: r.expr([1,2]) + [3] + [4,5] + [6,7,8] */
                 var obtained = runOrCatch( r.expr(r.array(1L, 2L)).add(r.array(3L)).add(r.array(4L, 5L)).add(r.array(6L, 7L, 8L)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/add.yaml, #52
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "Expected type NUMBER but found STRING.", [1]) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type NUMBER but found STRING.", r.array(1L));
                 
                 /* Original: r.expr(1) + 'a' */
                 var obtained = runOrCatch( r.expr(1L).add("a") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/add.yaml, #57
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "Expected type STRING but found NUMBER.", [1]) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type STRING but found NUMBER.", r.array(1L));
                 
                 /* Original: r.expr('a') + 1 */
                 var obtained = runOrCatch( r.expr("a").add(1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/add.yaml, #62
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "Expected type ARRAY but found NUMBER.", [1]) */
                 var expected_ = err("ReqlQueryLogicError", "Expected type ARRAY but found NUMBER.", r.array(1L));
                 
                 /* Original: r.expr([]) + 1 */
                 var obtained = runOrCatch( r.expr(r.array()).add(1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             

        }
    }
}
