(function(e){function t(t){for(var a,i,o=t[0],l=t[1],c=t[2],p=0,k=[];p<o.length;p++)i=o[p],Object.prototype.hasOwnProperty.call(r,i)&&r[i]&&k.push(r[i][0]),r[i]=0;for(a in l)Object.prototype.hasOwnProperty.call(l,a)&&(e[a]=l[a]);m&&m(t);while(k.length)k.shift()();return n.push.apply(n,c||[]),s()}function s(){for(var e,t=0;t<n.length;t++){for(var s=n[t],a=!0,o=1;o<s.length;o++){var l=s[o];0!==r[l]&&(a=!1)}a&&(n.splice(t--,1),e=i(i.s=s[0]))}return e}var a={},r={app:0},n=[];function i(t){if(a[t])return a[t].exports;var s=a[t]={i:t,l:!1,exports:{}};return e[t].call(s.exports,s,s.exports,i),s.l=!0,s.exports}i.m=e,i.c=a,i.d=function(e,t,s){i.o(e,t)||Object.defineProperty(e,t,{enumerable:!0,get:s})},i.r=function(e){"undefined"!==typeof Symbol&&Symbol.toStringTag&&Object.defineProperty(e,Symbol.toStringTag,{value:"Module"}),Object.defineProperty(e,"__esModule",{value:!0})},i.t=function(e,t){if(1&t&&(e=i(e)),8&t)return e;if(4&t&&"object"===typeof e&&e&&e.__esModule)return e;var s=Object.create(null);if(i.r(s),Object.defineProperty(s,"default",{enumerable:!0,value:e}),2&t&&"string"!=typeof e)for(var a in e)i.d(s,a,function(t){return e[t]}.bind(null,a));return s},i.n=function(e){var t=e&&e.__esModule?function(){return e["default"]}:function(){return e};return i.d(t,"a",t),t},i.o=function(e,t){return Object.prototype.hasOwnProperty.call(e,t)},i.p="/";var o=window["webpackJsonp"]=window["webpackJsonp"]||[],l=o.push.bind(o);o.push=t,o=o.slice();for(var c=0;c<o.length;c++)t(o[c]);var m=l;n.push([0,"chunk-vendors"]),s()})({0:function(e,t,s){e.exports=s("56d7")},"034f":function(e,t,s){"use strict";var a=s("c21b"),r=s.n(a);r.a},"0919":function(e,t,s){},"0beb":function(e,t,s){"use strict";var a=s("30f2"),r=s.n(a);r.a},"0ff8":function(e,t,s){"use strict";var a=s("da97"),r=s.n(a);r.a},"12d9":function(e,t,s){},1617:function(e,t,s){"use strict";var a=s("3c86"),r=s.n(a);r.a},"30f2":function(e,t,s){},"3c86":function(e,t,s){},"47e4":function(e,t,s){"use strict";var a=s("9dcb"),r=s.n(a);r.a},"4eae":function(e,t,s){e.exports=s.p+"img/Fakta.19ed1a15.png"},5190:function(e,t,s){e.exports=s.p+"img/Guldtand.cb8c8b29.jpg"},"53ba":function(e,t,s){},5464:function(e,t,s){"use strict";var a=s("5501"),r=s.n(a);r.a},5501:function(e,t,s){},"56d7":function(e,t,s){"use strict";s.r(t);var a=s("2b0e"),r=function(){var e=this,t=e.$createElement,s=e._self._c||t;return s("div",{attrs:{id:"app"}},[s("Header"),s("div",{staticClass:"sidebar-panel-nav"},[s("Sidebar")],1),s("router-view")],1)},n=[],i=function(){var e=this,t=e.$createElement,a=e._self._c||t;return a("keep-alive",[a("div",{staticClass:"header"},[a("div",{staticClass:"TopPart"},[a("div",{staticClass:"title"},[a("router-link",{attrs:{to:"/"}},[a("img",{attrs:{src:s("5190"),alt:"Guldtand"}})]),a("button",{staticClass:"Login",attrs:{type:"button"}},[e._v("Login")]),a("router-link",{staticClass:"Create_user",attrs:{to:"/CreateUser",tag:"button"}},[e._v("Opret bruger")]),a("router-link",{staticClass:"MyPage",attrs:{to:"/ProfilePage",tag:"button"}},[e._v("Profile")])],1)]),a("div",{staticClass:"SearchBar"},[a("input",{staticStyle:{height:"32px",width:"704px"},attrs:{type:"text",placeholder:"Search...",required:""}})]),a("div",{staticClass:"SearchBarBtn"},[a("button",{staticClass:"SearchRecepie",staticStyle:{height:"32px"},attrs:{type:"button"}},[e._v("Søg opskrift")]),a("button",{staticStyle:{height:"32px"},attrs:{type:"button"}},[e._v("Søg ingrediens")])]),a("br",{staticStyle:{clear:"both"}}),a("div",{staticClass:"Buttons2"},[a("router-link",{staticClass:"btn_Top",attrs:{to:"/TopPage",tag:"button"}},[e._v("Top retter")]),a("router-link",{staticClass:"btn_New",attrs:{to:"/NewPage",tag:"button"}},[e._v("Nye retter")]),a("router-link",{staticClass:"btn_Su",attrs:{to:"/SUPage",tag:"button"}},[e._v("SU-retter")]),a("router-link",{staticClass:"btn_Vegi",attrs:{to:"/VegiPage",tag:"button"}},[e._v("Vegetar retter")]),a("router-link",{staticClass:"btn_Classic",attrs:{to:"/ClassicPage",tag:"button"}},[e._v("Klassiske retter")]),a("router-link",{staticClass:"btn_Store",attrs:{to:"/StorePage",tag:"button"}},[e._v("Vælg Butik")]),a("router-link",{staticClass:"btn_CreateRecipe",attrs:{to:"/CreateRecipe",tag:"button"}},[e._v("Opret Opskrift")])],1)])])},o=[],l={name:"Header",props:{}},c=l,m=(s("1617"),s("2877")),p=Object(m["a"])(c,i,o,!1,null,"951acf8a",null),k=p.exports,u=function(){var e=this,t=e.$createElement,a=e._self._c||t;return a("keep-alive",[a("div",{staticClass:"sidebar"},[a("transition",{attrs:{name:"slide"}},[e.isPanelOpen?a("div",{staticClass:"sidebar-panel"},[a("div",{staticClass:"butikkerValg"},[a("input",{attrs:{type:"checkbox",id:"cb1"}}),a("label",{attrs:{for:"cb1"}},[a("img",{attrs:{src:s("beb7"),alt:"Netto"}})]),a("br",{staticStyle:{clear:"both"}}),a("input",{attrs:{type:"checkbox",id:"cb2"}}),a("label",{attrs:{for:"cb2"}},[a("img",{attrs:{src:s("d8e6"),alt:"Foetex"}})]),a("br",{staticStyle:{clear:"both"}}),a("input",{attrs:{type:"checkbox",id:"cb3"}}),a("label",{attrs:{for:"cb3"}},[a("img",{attrs:{src:s("76f2"),alt:"Rema"}})]),a("br",{staticStyle:{clear:"both"}}),a("input",{attrs:{type:"checkbox",id:"cb4"}}),a("label",{attrs:{for:"cb4"}},[a("img",{attrs:{src:s("4eae"),alt:"Fakta"}})])]),a("br",{staticStyle:{clear:"both"}}),a("br",{staticStyle:{clear:"both"}}),a("div",{staticClass:"antalPersoner"},[a("select",[a("option",{attrs:{value:"0"}},[e._v("Antal Personer:")]),a("option",{attrs:{value:"1"}},[e._v("1 Person")]),a("option",{attrs:{value:"2"}},[e._v("2 Personer")]),a("option",{attrs:{value:"3"}},[e._v("3 Personer")]),a("option",{attrs:{value:"4"}},[e._v("4 Personer")]),a("option",{attrs:{value:"5"}},[e._v("5 Personer")]),a("option",{attrs:{value:"6"}},[e._v("6 Personer")]),a("option",{attrs:{value:"7"}},[e._v("7 Personer")]),a("option",{attrs:{value:"8"}},[e._v("8 Personer")]),a("option",{attrs:{value:"9"}},[e._v("9 Personer")]),a("option",{attrs:{value:"10"}},[e._v("10 Personer")])])]),a("div",{staticClass:"CheckboxDishes"},[a("br",{staticStyle:{clear:"both"}}),a("input",{staticClass:"cbox",attrs:{type:"checkbox",id:"dish1"}}),a("label",{attrs:{for:"dish1"}},[e._v("Pasta")]),a("br",{staticStyle:{clear:"both"}}),a("input",{staticClass:"cbox",attrs:{type:"checkbox",id:"dish2"}}),a("label",{attrs:{for:"dish2"}},[e._v("Ris")]),a("br",{staticStyle:{clear:"both"}}),a("input",{staticClass:"cbox",attrs:{type:"checkbox",id:"dish3"}}),a("label",{attrs:{for:"dish3"}},[e._v("Oksekød")]),a("br",{staticStyle:{clear:"both"}}),a("input",{staticClass:"cbox",attrs:{type:"checkbox",id:"dish4"}}),a("label",{attrs:{for:"dish4"}},[e._v("Svinekød")])])]):e._e()])],1)])},v=[],d={data:function(){return{isPanelOpen:!0}},methods:{closeSidebarPanel:function(){this.isPanelOpen=!1}}},D=d,_=(s("c21c"),Object(m["a"])(D,u,v,!1,null,"21fc3233",null)),f=_.exports,b={name:"app",components:{Header:k,Sidebar:f}},g=b,h=(s("034f"),Object(m["a"])(g,r,n,!1,null,null,null)),C=h.exports,y=s("8c4f"),P=function(){var e=this,t=e.$createElement;e._self._c;return e._m(0)},S=[function(){var e=this,t=e.$createElement,s=e._self._c||t;return s("div",{staticClass:"bodyHome"},[s("br",{staticStyle:{clear:"both"}}),s("h1",[e._v("Forside ������")]),e._v("\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n")])}],x={name:"Home",props:{}},w=x,O=(s("e623"),Object(m["a"])(w,P,S,!1,null,"87feb23c",null)),j=O.exports,z=function(){var e=this,t=e.$createElement,a=e._self._c||t;return a("div",{staticClass:"bodyTopPage"},[a("br",{staticStyle:{clear:"both"}}),a("h1",[e._v("Top Page")]),a("div",{staticClass:"viewOfRecepie"},[a("div",{staticClass:"imageOfRecepie"},[a("img",{attrs:{src:s("e1f8")}}),a("router-link",{staticClass:"recepieImg",attrs:{to:"/Recepie/PizzaHomemade",tag:"img"}})],1),a("div",{staticClass:"textForPrice"},[a("div",{staticStyle:{"font-size":"25px"}},[e._v("\n                "+e._s(e.recepie.name)+" "),a("br")]),e._v("\n            Original pris: "+e._s(e.recepie.priceOrginal)+"kr. "),a("br"),e._v("\n            Pris med rabat: "+e._s(e.recepie.priceDiscount)+"kr. "),a("br"),e._v("\n            Laveste mulige pris: "+e._s(e.recepie.priceLowest)+"kr. "),a("br")])]),a("div",{staticClass:"viewOfRecepie"},[e._m(0),a("div",{staticClass:"textForPrice"},[a("div",{staticStyle:{"font-size":"25px"}},[e._v("\n                "+e._s(e.recepie.name)+" "),a("br")]),e._v("\n            Original pris: "+e._s(e.recepie.priceOrginal)+"kr. "),a("br"),e._v("\n            Pris med rabat: "+e._s(e.recepie.priceDiscount)+"kr. "),a("br"),e._v("\n            Laveste mulige pris: "+e._s(e.recepie.priceLowest)+"kr. "),a("br")])]),a("div",{staticClass:"viewOfRecepie"},[e._m(1),a("div",{staticClass:"textForPrice"},[a("div",{staticStyle:{"font-size":"25px"}},[e._v("\n                "+e._s(e.recepie.name)+" "),a("br")]),e._v("\n            Original pris: "+e._s(e.recepie.priceOrginal)+"kr. "),a("br"),e._v("\n            Pris med rabat: "+e._s(e.recepie.priceDiscount)+"kr. "),a("br"),e._v("\n            Laveste mulige pris: "+e._s(e.recepie.priceLowest)+"kr. "),a("br")])]),a("div",{staticClass:"viewOfRecepie"},[e._m(2),a("div",{staticClass:"textForPrice"},[a("div",{staticStyle:{"font-size":"25px"}},[e._v("\n                "+e._s(e.recepie.name)+" "),a("br")]),e._v("\n            Original pris: "+e._s(e.recepie.priceOrginal)+"kr. "),a("br"),e._v("\n            Pris med rabat: "+e._s(e.recepie.priceDiscount)+"kr. "),a("br"),e._v("\n            Laveste mulige pris: "+e._s(e.recepie.priceLowest)+"kr. "),a("br")])])])},E=[function(){var e=this,t=e.$createElement,a=e._self._c||t;return a("div",{staticClass:"imageOfRecepie"},[a("img",{attrs:{src:s("e1f8")}})])},function(){var e=this,t=e.$createElement,a=e._self._c||t;return a("div",{staticClass:"imageOfRecepie"},[a("img",{attrs:{src:s("e1f8")}})])},function(){var e=this,t=e.$createElement,a=e._self._c||t;return a("div",{staticClass:"imageOfRecepie"},[a("img",{attrs:{src:s("e1f8")}})])}],R={name:"TopPage",data:function(){return{recepie:{pic:"@/assets/Pics/Pizza_Picture.jpg",name:"Hjemmelavet pizza med tomatsovs, peperoni og ost",priceOrginal:"50",priceDiscount:"35",priceLowest:"35",alt:"Pizza",info:"Bla bla?"}}}},$=R,N=(s("47e4"),Object(m["a"])($,z,E,!1,null,"c6905f32",null)),T=N.exports,F=function(){var e=this,t=e.$createElement;e._self._c;return e._m(0)},L=[function(){var e=this,t=e.$createElement,s=e._self._c||t;return s("div",{staticClass:"bodyNewPage"},[s("br",{staticStyle:{clear:"both"}}),s("h1",[e._v("Nye retter")]),e._v("\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n")])}],H={name:"NewPage",props:{}},B=H,V=(s("841f"),Object(m["a"])(B,F,L,!1,null,"16105988",null)),U=V.exports,M=function(){var e=this,t=e.$createElement;e._self._c;return e._m(0)},A=[function(){var e=this,t=e.$createElement,s=e._self._c||t;return s("div",{staticClass:"bodySUPage"},[s("br",{staticStyle:{clear:"both"}}),s("h1",[e._v("Cheap ass lækker mad")]),e._v("\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n")])}],G={name:"SUPage",props:{}},q=G,I=(s("e846"),Object(m["a"])(q,M,A,!1,null,"4590fbf2",null)),J=I.exports,K=function(){var e=this,t=e.$createElement;e._self._c;return e._m(0)},Q=[function(){var e=this,t=e.$createElement,s=e._self._c||t;return s("div",{staticClass:"bodyVegiPage"},[s("br",{staticStyle:{clear:"both"}}),s("h1",[e._v("Vegetar fis")]),e._v("\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n")])}],W={name:"VegiPage",props:{}},X=W,Y=(s("5464"),Object(m["a"])(X,K,Q,!1,null,"53345e4c",null)),Z=Y.exports,ee=function(){var e=this,t=e.$createElement;e._self._c;return e._m(0)},te=[function(){var e=this,t=e.$createElement,s=e._self._c||t;return s("div",{staticClass:"bodyClassicPage"},[s("br",{staticStyle:{clear:"both"}}),s("h1",[e._v("Fino bambino siden")]),e._v("\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n")])}],se={name:"ClassicPage",props:{}},ae=se,re=(s("0ff8"),Object(m["a"])(ae,ee,te,!1,null,"63c992a2",null)),ne=re.exports,ie=function(){var e=this,t=e.$createElement,s=e._self._c||t;return s("div",{staticClass:"bodyStorePage"},[s("br",{staticStyle:{clear:"both"}}),s("h1",[e._v("Nye retter")]),s("div",{attrs:{id:"StorePage"}},[e._v(e._s(e.msg))]),e._v("Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n    Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst\n")])},oe=[],le={name:"StorePage",props:{},data:function(){return{msg:"Det virker"}}},ce=le,me=(s("a465"),s("6749")),pe=s.n(me),ke=Object(m["a"])(ce,ie,oe,!1,null,"e62de49c",null);"function"===typeof pe.a&&pe()(ke);var ue=ke.exports,ve=function(){var e=this,t=e.$createElement,s=e._self._c||t;return s("div",{staticClass:"bodyProfilePage"},[s("br",{staticStyle:{clear:"both"}}),s("h2",[e._v("Brugernavn: ")]),s("button",{staticClass:"resetPassword"},[e._v("�ndre adgangskode")]),s("br",{staticStyle:{clear:"both"}}),e._m(0),s("div",{staticClass:"DishesMade"},[s("h2",[e._v("Retter oprettet af dig:")]),s("div",{staticClass:"viewOfRecepie"},[e._m(1),s("div",{staticClass:"textForPrice"},[s("div",{staticStyle:{"font-size":"25px"}},[e._v("\n                    "+e._s(e.recepie.name)+" "),s("br")]),e._v("\n                Original pris: "+e._s(e.recepie.priceOrginal)+"kr. "),s("br"),e._v("\n                Pris med rabat: "+e._s(e.recepie.priceDiscount)+"kr. "),s("br"),e._v("\n                Laveste mulige pris: "+e._s(e.recepie.priceLowest)+"kr. "),s("br")])])])])},de=[function(){var e=this,t=e.$createElement,s=e._self._c||t;return s("div",{staticClass:"Pref"},[s("h2",[e._v("Indstillinger")]),e._v("\n        For at �ndre indstillinger i forhold til butikker bruges sidebaren til venstre.\n    ")])},function(){var e=this,t=e.$createElement,a=e._self._c||t;return a("div",{staticClass:"imageOfRecepie"},[a("img",{attrs:{src:s("e1f8")}})])}],De={name:"ProfilePage",data:function(){return{recepie:{pic:"@/assets/Pics/Pizza_Picture.jpg",name:"Hjemmelavet pizza med tomatsovs, peperoni og ost",priceOrginal:"50",priceDiscount:"35",priceLowest:"35",alt:"Pizza",info:"Bla bla?"}}}},_e=De,fe=(s("8644"),Object(m["a"])(_e,ve,de,!1,null,"4b20d2f6",null)),be=fe.exports,ge=function(){var e=this,t=e.$createElement;e._self._c;return e._m(0)},he=[function(){var e=this,t=e.$createElement,a=e._self._c||t;return a("div",{staticClass:"bodyStorePage"},[a("br",{staticStyle:{clear:"both"}}),a("h1",[e._v("Hjemmelavet pizza med tomatsovs, peperoni og ost")]),a("div",{staticClass:"recepie"},[a("div",{staticClass:"ingredienser"},[a("p",{staticClass:"p2"},[a("span",{staticClass:"s1"},[e._v("45 min. + hæve- og bagetid"),a("br")]),e._v("Til 4 personer")]),a("div",{staticClass:"image"},[a("img",{attrs:{src:s("e1f8")}})]),a("br",{staticStyle:{clear:"both"}}),a("p",{staticClass:"p3"},[a("strong",[e._v("INGREDIENSER")])]),a("div",{staticClass:"i1"},[a("p",{staticClass:"p3"},[a("strong",[e._v("Pizzadej")])]),a("ul",[a("li",{staticClass:"p4"},[e._v("15 g gær")]),a("li",{staticClass:"p4"},[e._v("3 1/2 dl lunkent vand")]),a("li",{staticClass:"p4"},[e._v("1 spsk olivenolie")]),a("li",{staticClass:"p4"},[e._v("1 1/2 tsk salt")]),a("li",{staticClass:"p4"},[e._v("225 g fuldkornsmel")]),a("li",{staticClass:"p4"},[e._v("\n                        ca. 225 g italiensk hvedemel\n                    ")])])]),a("div",{staticClass:"i2"},[a("p",{staticClass:"p2"},[a("strong",[a("span",{staticClass:"s1"},[e._v("Pizzasauce")])])]),a("ul",[a("li",{staticClass:"p4"},[e._v("1/2 løg")]),a("li",{staticClass:"p4"},[e._v("1 fed hvidløg")]),a("li",{staticClass:"p4"},[e._v("1 ds hakkede tomater")]),a("li",{staticClass:"p4"},[e._v("1/2 spsk honning eller sirup")]),a("li",{staticClass:"p4"},[e._v("1/2 tsk oregano")]),a("li",{staticClass:"p4"},[e._v("1/2 tsk basilikum")]),a("li",{staticClass:"p4"},[e._v("1/2 tsk chiliflager")]),a("li",{staticClass:"p4"},[e._v("1/2 tsk salt")])])]),a("div",{staticClass:"i3"},[a("p",{staticClass:"p3"},[a("strong",[e._v("Topping")])]),a("ul",[a("li",{staticClass:"p4"},[e._v("2 peberfrugter")]),a("li",{staticClass:"p4"},[e._v("125 g champignoner")]),a("li",{staticClass:"p4"},[e._v("100 g pepperoni")]),a("li",{staticClass:"p4"},[e._v("100 g ost maks. 30+")])])])]),a("br",{staticStyle:{clear:"both"}}),a("div",{staticClass:"f1"},[a("h3",[e._v("FREMGANGSMÅDE")]),a("p",[e._v("1. Rør gæren ud i lunkent vand, og tilsæt de øvrige ingredienser til dejen. ælt dejen 5 min., og lad den hæve ca. 1 time.")]),a("p",[e._v("2. Pil løg og hvidløg, og riv dem groft. Hæld tomaterne i en sigte over en skål. Blend tomaterne med de øvrige ingredienser til saucen, og juster tykkelsen med den afdryppede tomatsaft. Lad saucen trække ved stuetemperatur 1/2 times tid.")]),a("p",[e._v("3. Skær peberfrugt i tynde strimler og champignon i skiver. Skær pølsen i tynde skiver, og riv osten groft.")]),a("p",[e._v("4. Sæt dine bageplader i ovnen, og tænd på 250-275 grader varmluft - så højt, din ovn kan komme op.")]),a("p",[e._v("5. Vend dejen ud på et meldrysset bord, og del den i 4 lige store stykker. Form dem til kugler, rul dem tyndt ud til bunde, og læg dem på bagepapir. Smør saucen på pizza-erne, men lad kanten gå fri.")]),a("p",[e._v("6. Fordel peberfrugt, champignon, pepperoni og ost ovenpå. Flyt pizzaerne ind på de brandvarme bageplader med en pizzaspade eller ved hjælp af en plade, bakke eller et bræt.")]),a("p",[e._v("7. Bag, til dejen er gennembagt, og osten er smeltet - ca. 10 min. Server straks.")]),a("p",[a("strong",[a("br"),e._v("Tip!")]),e._v(" Udvid fyldet med andre grøntsager - gerne rester af dampede eller stegte grøntsager eller kogte kartofler.")])])])])}],Ce={name:"PizzaHomemade",props:{}},ye=Ce,Pe=(s("0beb"),Object(m["a"])(ye,ge,he,!1,null,"5959b078",null)),Se=Pe.exports,xe=function(){var e=this,t=e.$createElement;e._self._c;return e._m(0)},we=[function(){var e=this,t=e.$createElement,s=e._self._c||t;return s("div",{staticClass:"Login"},[s("form",{staticStyle:{border:"1px solid #ccc"},attrs:{action:"/action_page.php"}},[s("div",{staticClass:"container"},[s("h1",[e._v("Tilmeld")]),s("p",[e._v(" Udfyld venligst denne formular for at oprette en konto.")]),s("hr"),s("label",{attrs:{for:"email"}},[s("b",[e._v("Email")])]),s("input",{attrs:{type:"text",placeholder:"Skriv Email",name:"email",required:""}}),s("label",{attrs:{for:"psw"}},[s("b",[e._v("Adgangskode")])]),s("input",{attrs:{type:"password",placeholder:"Kriv Adgangskode",name:"psw",required:""}}),s("label",{attrs:{for:"psw-repeat"}},[s("b",[e._v("Gentag Adgangskode")])]),s("input",{attrs:{type:"password",placeholder:"Gentag Adgangskode",name:"psw-repeat",required:""}}),s("label",[s("input",{staticStyle:{"margin-bottom":"15px"},attrs:{type:"checkbox",checked:"checked",name:"remember"}}),e._v(" Husk mig\n            ")]),s("p",[e._v("By creating an account you agree to our "),s("a",{staticStyle:{color:"dodgerblue"},attrs:{href:"#"}},[e._v("Terms & Privacy")]),e._v(".")]),s("div",{staticClass:"clearfix"},[s("button",{staticClass:"cancelbtn",attrs:{type:"button"}},[e._v("Annuler")]),s("button",{staticClass:"signupbtn",attrs:{type:"submit"}},[e._v("Tilmeld")])])])])])}],Oe={name:"CreateUser",props:{}},je=Oe,ze=(s("c8f7"),Object(m["a"])(je,xe,we,!1,null,"6546b42c",null)),Ee=ze.exports,Re=function(){var e=this,t=e.$createElement,s=e._self._c||t;return s("div",{staticClass:"bodyCreateRecipe"},[s("br",{staticStyle:{clear:"both"}}),e._m(0),s("h2",[e._v("\n        Navn på opskrift\n    ")]),e._m(1),s("h2",[e._v("\n        Vælg forberedelses tid\n    ")]),e._m(2),s("h2",[e._v("\n        Skriv fremgangsmåde:\n    ")]),s("div",{staticClass:"rows1"},[s("button",{on:{click:e.addRow1}},[e._v("Tilføj nyt punkt")]),s("ul",e._l(e.inputs1,function(t,a){return s("li",{key:t},[s("input",{directives:[{name:"model",rawName:"v-model",value:t.one,expression:"input1.one"}],attrs:{type:"text",placeholder:"..."},domProps:{value:t.one},on:{input:function(s){s.target.composing||e.$set(t,"one",s.target.value)}}}),s("button",{staticClass:"btn_delete",on:{click:function(t){e.deleteRow1(a)}}},[e._v("Slet")])])}))]),s("h2",[e._v("\n        Skriv ingredienser:\n    ")]),s("div",{staticClass:"rows2"},[s("button",{on:{click:e.addRow2}},[e._v("Tilføj ny ingrediens")]),s("ul",e._l(e.inputs2,function(t,a){return s("li",{key:t},[s("input",{directives:[{name:"model",rawName:"v-model",value:t.one,expression:"input2.one"}],attrs:{type:"text",placeholder:"..."},domProps:{value:t.one},on:{input:function(s){s.target.composing||e.$set(t,"one",s.target.value)}}}),s("input",{directives:[{name:"model",rawName:"v-model",value:t.two,expression:"input2.two"}],staticClass:"unit_text",attrs:{type:"text"},domProps:{value:t.two},on:{input:function(s){s.target.composing||e.$set(t,"two",s.target.value)}}}),e._m(3,!0),s("button",{staticClass:"btn_delete",on:{click:function(t){e.deleteRow2(a)}}},[e._v("Slet")])])}))])])},$e=[function(){var e=this,t=e.$createElement,s=e._self._c||t;return s("h1",[e._v("\n        Ny Opskrift\n        "),s("br")])},function(){var e=this,t=e.$createElement,s=e._self._c||t;return s("div",{staticClass:"recipeName"},[s("input",{staticStyle:{height:"28px",width:"250px"},attrs:{type:"text",placeholder:"Indtast navn",required:""}})])},function(){var e=this,t=e.$createElement,s=e._self._c||t;return s("div",{staticClass:"antalPersoner"},[s("select",[s("option",{attrs:{value:"0"}},[e._v("Forberedelse tid")]),s("option",{attrs:{value:"1"}},[e._v("15 min")]),s("option",{attrs:{value:"2"}},[e._v("30 min")]),s("option",{attrs:{value:"3"}},[e._v("45 min")]),s("option",{attrs:{value:"4"}},[e._v("1 time")]),s("option",{attrs:{value:"5"}},[e._v("1 time 15 min")]),s("option",{attrs:{value:"6"}},[e._v("1 time 30 min")]),s("option",{attrs:{value:"7"}},[e._v("1 time 45 min")]),s("option",{attrs:{value:"8"}},[e._v("2 timer")]),s("option",{attrs:{value:"9"}},[e._v("2 timer 30 min")]),s("option",{attrs:{value:"10"}},[e._v("3 timer")])])])},function(){var e=this,t=e.$createElement,s=e._self._c||t;return s("select",{staticClass:"unit"},[s("option",{attrs:{value:"0"}},[e._v("g")]),s("option",{attrs:{value:"1"}},[e._v("kg")]),s("option",{attrs:{value:"2"}},[e._v("ml")]),s("option",{attrs:{value:"3"}},[e._v("dl")]),s("option",{attrs:{value:"4"}},[e._v("l")]),s("option",{attrs:{value:"5"}},[e._v("tsk")]),s("option",{attrs:{value:"6"}},[e._v("spsk")]),s("option",{attrs:{value:"7"}},[e._v("knsp")])])}],Ne={name:"CreateRecepie",data:function(){return{inputs1:[],inputs2:[]}},methods:{addRow1:function(){this.inputs1.push({one:""})},addRow2:function(){this.inputs2.push({one:"",two:""})},deleteRow1:function(e){this.inputs1.splice(e,1)},deleteRow2:function(e){this.inputs2.splice(e,1)}}},Te=Ne,Fe=(s("7707"),Object(m["a"])(Te,Re,$e,!1,null,"3f7a703e",null)),Le=Fe.exports,He=[{path:"/",component:j},{path:"/TopPage",component:T},{path:"/NewPage",component:U},{path:"/SUPage",component:J},{path:"/VegiPage",component:Z},{path:"/ClassicPage",component:ne},{path:"/StorePage",component:ue},{path:"/ProfilePage",component:be},{path:"/CreateUser",component:Ee},{path:"/CreateRecipe",component:Le},{path:"/Recepie/PizzaHomemade",component:Se}],Be=He;a["a"].config.productionTip=!0,a["a"].use(y["a"]);var Ve=new y["a"]({routes:Be});new a["a"]({router:Ve,render:function(e){return e(C)}}).$mount("#app")},6749:function(e,t){},"76f2":function(e,t,s){e.exports=s.p+"img/Rema.039d449b.jpg"},7707:function(e,t,s){"use strict";var a=s("7cba"),r=s.n(a);r.a},"7cba":function(e,t,s){},"841f":function(e,t,s){"use strict";var a=s("9509"),r=s.n(a);r.a},8644:function(e,t,s){"use strict";var a=s("c59a"),r=s.n(a);r.a},"8d81":function(e,t,s){},9509:function(e,t,s){},"9dcb":function(e,t,s){},a465:function(e,t,s){"use strict";var a=s("c1e0"),r=s.n(a);r.a},beb7:function(e,t,s){e.exports=s.p+"img/Netto.355d05e9.png"},c1e0:function(e,t,s){},c21b:function(e,t,s){},c21c:function(e,t,s){"use strict";var a=s("8d81"),r=s.n(a);r.a},c59a:function(e,t,s){},c8f7:function(e,t,s){"use strict";var a=s("53ba"),r=s.n(a);r.a},d8e6:function(e,t,s){e.exports=s.p+"img/Foetex.e4a98856.png"},da97:function(e,t,s){},e1f8:function(e,t,s){e.exports=s.p+"img/Pizza_Picture.f5eb4f6c.jpg"},e623:function(e,t,s){"use strict";var a=s("12d9"),r=s.n(a);r.a},e846:function(e,t,s){"use strict";var a=s("0919"),r=s.n(a);r.a}});
//# sourceMappingURL=app.ec2b8c67.js.map