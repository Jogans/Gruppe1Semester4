<template>
    <div class="bodySearchsite">
        <div class="container">
            <h1 class="text-primary text-center">{{title}}</h1>
        </div>
    </div>
    

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
    .bodySearchsite {
        width: 100%;
        max-width: 65%;
        margin: auto;
    }
</style>