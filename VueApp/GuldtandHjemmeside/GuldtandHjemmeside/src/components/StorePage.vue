<head>
    <script src="https://unpkg.com/vue"></script>
</head>
<template>

    <div class="bodyStorePage">
        <br style="clear:both" />
        <h1>Nye retter</h1>
        <div id="StorePage">
            <br style="clear:both" />
            <div class="SearchBar">
                <input style="height: 32px; width: 704px;" type="text" v-model="searchParameter" placeholder="Search..." required>
            </div>
            <button class="test_btn" @click="created">Test</button>
            <span v-html="info">{{info}}</span>

            <br style="clear:both" />

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
                info: null,
                searchParameter: null
            }
        },

        methods: {
            created() {
                this.$http.get('https://localhost:44323/Home/searchProducts?words=' + this.searchParameter, {
                    headers: {
                        'Access-Control-Allow-Origin': '*',
                    },
                }).then(response => (this.info = response.data))
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
    img{

    }
</style>

