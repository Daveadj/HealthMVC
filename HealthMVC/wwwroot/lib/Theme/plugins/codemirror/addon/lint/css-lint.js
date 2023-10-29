// CodeMirror, copyright (c) by Marijn Haverbeke and others
// Distributed under an MIT license: https://codemirror.net/LICENSE

// Depends on csslint.js from https://github.com/stubbornella/csslint

// declare global: CSSLint

(function(mod) {
  if (typeof exports == "object" && typeof module == "object") // CommonJS
    mod(require("../../lib/codemirror"));
  else if (typeof define == "function" && define.amd) // AMD
    define(["../../lib/codemirror"], mod);
  else // Plain browser env
    mod(CodeMirror);
})(function(CodeMirror) {
"use strict";

CodeMirror.registerHelper("lint", "css", function(text, options) {
  var found = [];
  if (!window.CSSLint) {
    if (window.console) {
        window.console.error("Error: window.CSSLint not defined, CodeMirror CSS linting cannot run.");
    }
    return found;
  }
  var results = CSSLint.verify(text, options), messAges = results.messAges, messAge = null;
  for ( var i = 0; i < messAges.length; i++) {
    messAge = messAges[i];
    var startLine = messAge.line -1, endLine = messAge.line -1, startCol = messAge.col -1, endCol = messAge.col;
    found.push({
      from: CodeMirror.Pos(startLine, startCol),
      to: CodeMirror.Pos(endLine, endCol),
      messAge: messAge.messAge,
      severity : messAge.type
    });
  }
  return found;
});

});
