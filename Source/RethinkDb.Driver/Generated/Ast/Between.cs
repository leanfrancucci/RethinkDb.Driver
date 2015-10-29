












//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections;
using System.Collections.Generic;


namespace RethinkDb.Driver.Ast {

    public class Between : ReqlExpr {

    
    
    
/// <summary>
/// <para>Get all documents between two keys. Accepts three optional arguments: <code>index</code>,
/// <code>left_bound</code>, and <code>right_bound</code>. If <code>index</code> is set to the name of a secondary index,
/// <code>between</code> will return all documents where that index's value is in the specified range
/// (it uses the primary key by default). <code>left_bound</code> or <code>right_bound</code> may be set to <code>open</code>
/// or <code>closed</code> to indicate whether or not to include that endpoint of the range (by default,
/// <code>left_bound</code> is closed and <code>right_bound</code> is open).</para>
/// </summary>
/// <example><para>Example: Find all users with primary key &gt;= 10 and &lt; 20 (a normal half-open interval).</para>
/// <code>r.table('marvel').between(10, 20).run(conn, callback)
/// </code></example>
        public Between (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Get all documents between two keys. Accepts three optional arguments: <code>index</code>,
/// <code>left_bound</code>, and <code>right_bound</code>. If <code>index</code> is set to the name of a secondary index,
/// <code>between</code> will return all documents where that index's value is in the specified range
/// (it uses the primary key by default). <code>left_bound</code> or <code>right_bound</code> may be set to <code>open</code>
/// or <code>closed</code> to indicate whether or not to include that endpoint of the range (by default,
/// <code>left_bound</code> is closed and <code>right_bound</code> is open).</para>
/// </summary>
/// <example><para>Example: Find all users with primary key &gt;= 10 and &lt; 20 (a normal half-open interval).</para>
/// <code>r.table('marvel').between(10, 20).run(conn, callback)
/// </code></example>
        public Between (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Get all documents between two keys. Accepts three optional arguments: <code>index</code>,
/// <code>left_bound</code>, and <code>right_bound</code>. If <code>index</code> is set to the name of a secondary index,
/// <code>between</code> will return all documents where that index's value is in the specified range
/// (it uses the primary key by default). <code>left_bound</code> or <code>right_bound</code> may be set to <code>open</code>
/// or <code>closed</code> to indicate whether or not to include that endpoint of the range (by default,
/// <code>left_bound</code> is closed and <code>right_bound</code> is open).</para>
/// </summary>
/// <example><para>Example: Find all users with primary key &gt;= 10 and &lt; 20 (a normal half-open interval).</para>
/// <code>r.table('marvel').between(10, 20).run(conn, callback)
/// </code></example>
        public Between (Arguments args, OptArgs optargs)
         : base(TermType.BETWEEN, args, optargs) {
        }


    



    
///<summary>
/// "index": "T_STR",
///  "left_bound": "E_BOUND",
///  "right_bound": "E_BOUND"
///</summary>
        public Between this[object optArgs] {
            get
            {
                var newOptargs = OptArgs.fromMap(this.OptArgs).with(optArgs);
        
                return new Between (this.Args, newOptargs);
            }
        }
        
///<summary>
/// "index": "T_STR",
///  "left_bound": "E_BOUND",
///  "right_bound": "E_BOUND"
///</summary>
        public Between optArg(string key, object val){
            
            var newOptargs = OptArgs.fromMap(this.OptArgs).with(key, val);
        
            return new Between (this.Args, newOptargs);
        }


    

    


    
    }
}
