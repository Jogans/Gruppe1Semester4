<template>
    <div id="app">
        <Header />
        <Sidebar />
        <router-view /> 
    </div>
</template>

<script>
    import Header from './components/Header.vue';
    import Sidebar from './components/Sidebar.vue';
    export default { 
        name: 'app',
        components: {
            Header,
            Sidebar
        }
    };
</script>

<style>
     .main-nav {
   display: flex;
   justify-content: space-between;
   padding: 0.5rem 0.8rem;
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
</style>