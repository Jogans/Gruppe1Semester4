<template>
    <div class="bodySearchsite">
        <div class="container">
            <h1 class="text-primary text-center">{{title}}</h1>
        </div>
    </div>
    <!-- <div class="bodySearchsite">
        <br style="clear:both" />
        <h1>Search</h1>

    </div> -->

</template>

<script>
    export default {
        name: 'Searchsite',
        data() {
            return {
                title: "Searchsite"
            }
        }
    }
</script>

<style scoped>
    .bodyClassicPage {
        width: 100%;
        max-width: 65%;
        margin: auto;
    }
</style>