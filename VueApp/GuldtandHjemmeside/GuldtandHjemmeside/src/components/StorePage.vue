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
            {{info}}
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
                test: 'Det virker',
                info: null
            }
        },
        methods: {
            async loadPage(page) {
                this.currentPage = page;

                try {
                    let response = await this.$http.get("https://www.google.com/");
                    window.alert(response.data);
                } catch (err) {
                    window.alert(err);
                }
            },
            created() {
                this.$http.get('https://www.example.com/', {
                    headers: {
                        'Access-Control-Allow-Origin': '*',
                    },
                }).then(response => (this.info = response))
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

