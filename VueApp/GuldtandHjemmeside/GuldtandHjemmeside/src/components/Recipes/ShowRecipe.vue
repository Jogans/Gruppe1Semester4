<template>
    <div class="showRecipePage">
        <br style="clear:both" />
        <h1>Test af vis opskrift</h1>
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
    export default {
        name: 'ShowRecipe',
        props: {
        },
        data: function () {
            return {
                info: null,
                searchParameter: null
            }
        },
        methods: {
            created() {
                this.$http.get('https://localhost:44324/Home/viewASpeceficRecipe?words=' + this.searchParameter, {
                    headers: {
                        'Access-Control-Allow-Origin': '*',
                    },
                }).then(response => (this.info = response.data))
            }
        }
    };
</script>

<style scoped>
                .showRecipePage {
    width: 100%;
    max-width: 65%;
    margin: auto;
}
                        img{
    display: block;
    position: relative;
    width: 525px;
    height: 300px;
    float: left;
}

    .i1 {
        float: left;
        position: relative;
    }

    .i2 {
        float: left;
        position: relative;
        padding-left: 10px;
    }

    .i3 {
        float: left;
        position: relative;
        padding-left: 10px;
    }
            .bodyStorePage {
    width: 100%;
    max-width: 65%;
    margin: auto;
}
</style>