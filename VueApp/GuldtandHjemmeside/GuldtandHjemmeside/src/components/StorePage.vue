<head>
    <script src="https://unpkg.com/vue"></script>
</head>
<template>
    
    <div class="bodyStorePage">
        <br style="clear:both" />
        <h1>Nye retter</h1>
        <div id="StorePage">{{msg}}</div>Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst
        Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst
        Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst
        Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst
        Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst
        Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst
        Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst
        Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst
        Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst
        Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst Dette er en masse tekst
    </div>
</template>


    
    
<script src="https://unpkg.com/vue">
    //import Vue from 'vue';
    //Vue.msg = "tester tester";
    //document.getElementById("tilbud").innerHTML = "Tester dette!!";
    new Vue({
        el: '#StorePage',
        data:{
            msg: 'data'
    }
    })
    export default {
        name: 'StorePage',
        props: {
        },
        data() {
            //console.log("Dette virker.");
            return {
                msg: 'Det virker'
            }
        }
    };
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

    .bodyStorePage {
        width: 100%;
        max-width: 65%;
        margin: auto;
    }
</style>

