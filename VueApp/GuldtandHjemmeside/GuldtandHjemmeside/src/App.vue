<template>
    <div id="app">
        <Header />
        <div class="sidebar-panel-nav">
            <Sidebar />
        </div>
        <router-view /> 
    </div>
</template>

<script>
    import Header from './components/Header.vue';
    import Sidebar from './components/Sidebar.vue';

    export default { 
        name: 'app',
        props: {
            checkedStringProp: String,
        },
        components: {
            Header,
            Sidebar
        }
    };
</script>

<style>

    @media only screen and (max-width: 600px) {}

    .main-nav {
       display: flex;
       justify-content: space-between;
       padding: 0.5rem 0.8rem;
    }

    .body {
        width: 100%;
        max-width: 65%;
        margin: auto;
    }

     ul.sidebar-panel-nav {
       list-style-type: none;
     }

     ul.sidebar-panel-nav > li > a {
       color: #fff;
       text-decoration: none;
       font-size: 1.5rem;
       display: block;
       padding-bottom: 0.5em;
     }

     #app {
         /*width:100%;
         max-width: 65%;
         padding-left:15%;*/
         font-family: "Avenir", Helvetica, Arial, sans-serif;
         -webkit-font-smoothing: antialiased;
         -moz-osx-font-smoothing: grayscale;
}
</style>