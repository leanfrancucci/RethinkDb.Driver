




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

    // These tests are aimed at &&, ||, and !

    [TestFixture]
    public class MathLogicLogic : GeneratedTest {

        public MathLogicLogic (){
        }




        [Test]
        public void YamlTest(){

             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #8
                 /* ExpectedOriginal: true */
                 var expected_ = true;
                 
                 /* Original: r.expr(true) & true */
                 var obtained = runOrCatch( r.expr(true).and(true) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #9
                 /* ExpectedOriginal: true */
                 var expected_ = true;
                 
                 /* Original: true & r.expr(true) */
                 var obtained = runOrCatch( r.and(true, r.expr(true)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #10
                 /* ExpectedOriginal: true */
                 var expected_ = true;
                 
                 /* Original: r.and_(true,true) */
                 var obtained = runOrCatch( r.and(true, true) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #11
                 /* ExpectedOriginal: true */
                 var expected_ = true;
                 
                 /* Original: r.expr(true).and_(true) */
                 var obtained = runOrCatch( r.expr(true).and(true) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #22
                 /* ExpectedOriginal: false */
                 var expected_ = false;
                 
                 /* Original: r.expr(true) & false */
                 var obtained = runOrCatch( r.expr(true).and(false) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #23
                 /* ExpectedOriginal: false */
                 var expected_ = false;
                 
                 /* Original: r.expr(false) & false */
                 var obtained = runOrCatch( r.expr(false).and(false) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #24
                 /* ExpectedOriginal: false */
                 var expected_ = false;
                 
                 /* Original: true & r.expr(false) */
                 var obtained = runOrCatch( r.and(true, r.expr(false)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #25
                 /* ExpectedOriginal: false */
                 var expected_ = false;
                 
                 /* Original: false & r.expr(false) */
                 var obtained = runOrCatch( r.and(false, r.expr(false)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #26
                 /* ExpectedOriginal: false */
                 var expected_ = false;
                 
                 /* Original: r.and_(true,false) */
                 var obtained = runOrCatch( r.and(true, false) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #27
                 /* ExpectedOriginal: false */
                 var expected_ = false;
                 
                 /* Original: r.and_(false,false) */
                 var obtained = runOrCatch( r.and(false, false) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #28
                 /* ExpectedOriginal: false */
                 var expected_ = false;
                 
                 /* Original: r.expr(true).and_(false) */
                 var obtained = runOrCatch( r.expr(true).and(false) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #29
                 /* ExpectedOriginal: false */
                 var expected_ = false;
                 
                 /* Original: r.expr(false).and_(false) */
                 var obtained = runOrCatch( r.expr(false).and(false) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #48
                 /* ExpectedOriginal: true */
                 var expected_ = true;
                 
                 /* Original: r.expr(true) | true */
                 var obtained = runOrCatch( r.expr(true).or(true) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #49
                 /* ExpectedOriginal: true */
                 var expected_ = true;
                 
                 /* Original: r.expr(true) | false */
                 var obtained = runOrCatch( r.expr(true).or(false) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #50
                 /* ExpectedOriginal: true */
                 var expected_ = true;
                 
                 /* Original: true | r.expr(true) */
                 var obtained = runOrCatch( r.or(true, r.expr(true)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #51
                 /* ExpectedOriginal: true */
                 var expected_ = true;
                 
                 /* Original: true | r.expr(false) */
                 var obtained = runOrCatch( r.or(true, r.expr(false)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #52
                 /* ExpectedOriginal: true */
                 var expected_ = true;
                 
                 /* Original: r.or_(true,true) */
                 var obtained = runOrCatch( r.or(true, true) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #53
                 /* ExpectedOriginal: true */
                 var expected_ = true;
                 
                 /* Original: r.or_(true,false) */
                 var obtained = runOrCatch( r.or(true, false) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #54
                 /* ExpectedOriginal: true */
                 var expected_ = true;
                 
                 /* Original: r.expr(true).or_(true) */
                 var obtained = runOrCatch( r.expr(true).or(true) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #55
                 /* ExpectedOriginal: true */
                 var expected_ = true;
                 
                 /* Original: r.expr(true).or_(false) */
                 var obtained = runOrCatch( r.expr(true).or(false) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #72
                 /* ExpectedOriginal: false */
                 var expected_ = false;
                 
                 /* Original: r.expr(false) | false */
                 var obtained = runOrCatch( r.expr(false).or(false) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #73
                 /* ExpectedOriginal: false */
                 var expected_ = false;
                 
                 /* Original: false | r.expr(false) */
                 var obtained = runOrCatch( r.or(false, r.expr(false)) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #74
                 /* ExpectedOriginal: false */
                 var expected_ = false;
                 
                 /* Original: r.and_(false,false) */
                 var obtained = runOrCatch( r.and(false, false) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #75
                 /* ExpectedOriginal: false */
                 var expected_ = false;
                 
                 /* Original: r.expr(false).and_(false) */
                 var obtained = runOrCatch( r.expr(false).and(false) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #88
                 /* ExpectedOriginal: false */
                 var expected_ = false;
                 
                 /* Original: ~r.expr(True) */
                 var obtained = runOrCatch( r.expr(true).not() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #89
                 /* ExpectedOriginal: false */
                 var expected_ = false;
                 
                 /* Original: r.not_(True) */
                 var obtained = runOrCatch( r.not(true) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #93
                 /* ExpectedOriginal: true */
                 var expected_ = true;
                 
                 /* Original: ~r.expr(False) */
                 var obtained = runOrCatch( r.expr(false).not() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #94
                 /* ExpectedOriginal: true */
                 var expected_ = true;
                 
                 /* Original: r.not_(False) */
                 var obtained = runOrCatch( r.not(false) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #97
                 /* ExpectedOriginal: false */
                 var expected_ = false;
                 
                 /* Original: r.expr(True).not_() */
                 var obtained = runOrCatch( r.expr(true).not() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #100
                 /* ExpectedOriginal: true */
                 var expected_ = true;
                 
                 /* Original: r.expr(False).not_() */
                 var obtained = runOrCatch( r.expr(false).not() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #107
                 /* ExpectedOriginal: true */
                 var expected_ = true;
                 
                 /* Original: ~r.and_(True, True) == r.or_(~r.expr(True), ~r.expr(True)) */
                 var obtained = runOrCatch( r.and(true, true).not().eq(r.or(r.expr(true).not(), r.expr(true).not())) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #108
                 /* ExpectedOriginal: true */
                 var expected_ = true;
                 
                 /* Original: ~r.and_(True, False) == r.or_(~r.expr(True), ~r.expr(False)) */
                 var obtained = runOrCatch( r.and(true, false).not().eq(r.or(r.expr(true).not(), r.expr(false).not())) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #109
                 /* ExpectedOriginal: true */
                 var expected_ = true;
                 
                 /* Original: ~r.and_(False, False) == r.or_(~r.expr(False), ~r.expr(False)) */
                 var obtained = runOrCatch( r.and(false, false).not().eq(r.or(r.expr(false).not(), r.expr(false).not())) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #110
                 /* ExpectedOriginal: true */
                 var expected_ = true;
                 
                 /* Original: ~r.and_(False, True) == r.or_(~r.expr(False), ~r.expr(True)) */
                 var obtained = runOrCatch( r.and(false, true).not().eq(r.or(r.expr(false).not(), r.expr(true).not())) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #120
                 /* ExpectedOriginal: true */
                 var expected_ = true;
                 
                 /* Original: r.and_(True, True, True, True, True) */
                 var obtained = runOrCatch( r.and(true, true, true, true, true) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #123
                 /* ExpectedOriginal: false */
                 var expected_ = false;
                 
                 /* Original: r.and_(True, True, True, False, True) */
                 var obtained = runOrCatch( r.and(true, true, true, false, true) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #126
                 /* ExpectedOriginal: false */
                 var expected_ = false;
                 
                 /* Original: r.and_(True, False, True, False, True) */
                 var obtained = runOrCatch( r.and(true, false, true, false, true) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #129
                 /* ExpectedOriginal: false */
                 var expected_ = false;
                 
                 /* Original: r.or_(False, False, False, False, False) */
                 var obtained = runOrCatch( r.or(false, false, false, false, false) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #132
                 /* ExpectedOriginal: true */
                 var expected_ = true;
                 
                 /* Original: r.or_(False, False, False, True, False) */
                 var obtained = runOrCatch( r.or(false, false, false, true, false) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #135
                 /* ExpectedOriginal: true */
                 var expected_ = true;
                 
                 /* Original: r.or_(False, True, False, True, False) */
                 var obtained = runOrCatch( r.or(false, true, false, true, false) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #140
                 /* ExpectedOriginal: err("ReqlQueryLogicError", "Cannot perform bracket on a non-object non-sequence `\"a\"`.", []) */
                 var expected_ = err("ReqlQueryLogicError", "Cannot perform bracket on a non-object non-sequence `\"a\"`.", r.array());
                 
                 /* Original: r.expr(r.expr('a')['b']).default(2) */
                 var obtained = runOrCatch( r.expr(r.expr("a").bracket("b")).default_(2L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #145
                 /* ExpectedOriginal: False */
                 var expected_ = false;
                 
                 /* Original: r.expr(r.and_(True, False) == r.or_(False, True)) */
                 var obtained = runOrCatch( r.expr(r.and(true, false).eq(r.or(false, true))) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #151
                 /* ExpectedOriginal: False */
                 var expected_ = false;
                 
                 /* Original: r.expr(r.and_(True, False) >= r.or_(False, True)) */
                 var obtained = runOrCatch( r.expr(r.and(true, false).ge(r.or(false, true))) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #155
                 /* ExpectedOriginal: true */
                 var expected_ = true;
                 
                 /* Original: r.expr(1) & True */
                 var obtained = runOrCatch( r.expr(1L).and(true) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #159
                 /* ExpectedOriginal: ("str") */
                 var expected_ = "str";
                 
                 /* Original: r.expr(False) | 'str' */
                 var obtained = runOrCatch( r.expr(false).or("str") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #163
                 /* ExpectedOriginal: false */
                 var expected_ = false;
                 
                 /* Original: ~r.expr(1) */
                 var obtained = runOrCatch( r.expr(1L).not() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, math_logic/logic.yaml, #167
                 /* ExpectedOriginal: true */
                 var expected_ = true;
                 
                 /* Original: ~r.expr(null) */
                 var obtained = runOrCatch( r.expr((ReqlExpr) null).not() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             

        }
    }
}
