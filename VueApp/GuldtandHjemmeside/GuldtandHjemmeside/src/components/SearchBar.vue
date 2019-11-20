<template>
    <div class="bodySearchBar">
        <br style="clear:both" />
        <br style="clear:both" />
        <div class="SearchBar">
            <input style="height: 32px; width: 704px;" type="text" v-model="searchParameter" placeholder="Search..." required>
        </div>

        <div class="SearchBarBtn">
            <button class="SearchRecepie" style="height: 32px;" type="button">S&#248;g opskrift</button>
            <button style="height: 32px;" @click="created" type="button">S&#248;g ingrediens</button>
        </div>
        <br style="clear:both" />

        <span v-html="info">{{info}}</span>
    </div>
</template>

<script>
        export default {
        name: 'SearchBar',
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
                this.$router.push({name:'Searchsite'})
                this.$http.get('https://localhost:44324/Home/searchProducts?words=' + this.searchParameter, {
                    headers: {
                        'Access-Control-Allow-Origin': '*',
                    },
                }).then(response => (this.info = response.data))
            },
            /*computed: {
                filteredList() {
                    return this.data.filter((info) => {
                        return info.toLowerCase().includes(this.searchParameter.toLowerCase());
                    });
                }
            }*/
        }
}
</script>

<style scoped>
        .SearchBar {
        float: left;
        display: inline-block;
        color: black;
        font-size: 24px;
        font-family: verdana;
        text-align: left;
        margin-top: 0px;
        float: left;
        margin: 0px;
        line-height: 40px;
    }

    .SearchBarBtn {
        float: left;
        display: block;
        color: black;
        font-size: 24px;
        float: left;
        margin: 6px;
        padding-right: 15px;
        padding-bottom: 10px;
    }
            .bodySearchBar {
    width: 100%;
    max-width: 65%;
    margin: auto;
}
</style>