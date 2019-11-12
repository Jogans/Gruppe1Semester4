<head>
    <script src="https://unpkg.com/vue"></script>
</head>
<template>

    <div class="bodyStorePage">
        <br style="clear:both" />
        <h1>Nye retter</h1>
        <div id="StorePage">
            <button class="test_btn" @click="created">Test</button>
            <br style="clear:both" />
            {{msg}}
            <br style="clear:both" />
            {{test}}

        </div>
    </div>
</template>




<script>
    //import Vue from 'vue';
    //Vue.msg = "tester tester";
    //document.getElementById("tilbud").innerHTML = "Tester dette!!";

    //new Vue({
    //    el: '#StorePage',
    //    data:{
    //        msg: 'data'
    //}
    //})
    export default {
        name: 'StorePage',
        props: {
        },
        data: function () {
            return {
                test: 'Det virker'
            }
        },
        methods: {
            created() {
                this.$http.get("http://skeldekrojmand.dk/tilbud.txt").then(res => {
                    this.msg = res.body
                })
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

