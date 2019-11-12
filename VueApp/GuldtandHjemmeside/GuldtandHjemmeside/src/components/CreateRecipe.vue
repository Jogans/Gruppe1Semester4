<template>
    <div class="bodyCreateRecipe">
        <br style="clear:both" />
        <h1>
            Ny Opskrift
            <br />
        </h1>
        <h2>
            Navn p&#229; opskrift
        </h2>

        <div class="recipeName">
            <input style="height: 28px; width: 250px;" type="text" placeholder="Indtast navn" required>
        </div>

        <h2>
            V&#230;lg forberedelses tid
        </h2>

        <div class="antalPersoner">
            <select>
                <option value="0">Forberedelse tid</option>
                <option value="1">15 min</option>
                <option value="2">30 min</option>
                <option value="3">45 min</option>
                <option value="4">1 time</option>
                <option value="5">1 time 15 min</option>
                <option value="6">1 time 30 min</option>
                <option value="7">1 time 45 min</option>
                <option value="8">2 timer</option>
                <option value="9">2 timer 30 min</option>
                <option value="10">3 timer</option>
            </select>
        </div>
        <h2>
            Skriv fremgangsm&#229;de:
        </h2>


        <div class="rows1">
            <button @click="addRow1">Tilf&#248;j nyt punkt</button>
            <ul>
                <li v-for="(input1, index1) in inputs1" v-bind:key="input1">
                    <input type="text" placeholder="..." v-model="input1.one" />
                    <button class="btn_delete" @click="deleteRow1(index1)">Slet</button>
                </li>
            </ul>
        </div>
        <h2>
            Skriv ingredienser:
        </h2>
        <div class="rows2">
            <button @click="addRow2">Tilf&#248;j ny ingrediens</button>
            <ul>
                <li v-for="(input2, index2) in inputs2" v-bind:key="input2">
                    <input type="text" placeholder="..." v-model="input2.one" />
                    <input class="unit_text" type="text" v-model="input2.two" />

                    <select class="unit">
                        <option value="0">g</option>
                        <option value="1">kg</option>
                        <option value="2">ml</option>
                        <option value="3">dl</option>
                        <option value="4">l</option>
                        <option value="5">tsk</option>
                        <option value="6">spsk</option>
                        <option value="7">knsp</option>

                    </select>
                    <button class="btn_delete" @click="deleteRow2(index2)">Slet</button>
                </li>
            </ul>
        </div>
    </div>
</template>

<script>
    export default {
        name: 'CreateRecepie',
        data: function () {
            return {
                inputs1: [],
                inputs2: []
            }
        },
        methods: {
            addRow1() {
                this.inputs1.push({
                    one: ''
                })
            },
            addRow2() {
                this.inputs2.push({
                    one: '',
                    two: ''
                })
            },
            deleteRow1(index1) {
                this.inputs1.splice(index1, 1)
            },
            deleteRow2(index2) {
                this.inputs2.splice(index2, 1)
            }
        }
    };
</script>

<style scoped>
    .bodyCreateRecipe {
        width: 100%;
        max-width: 65%;
        margin: auto;
    }

    .btn_addLine {
        margin-left: 50px;
    }

    .rows1 {
        width: auto;
    }

    .rows2 {
        width: auto;
    }

    input {
        width: 300px;
        height: 20px;
        font-size: 18px;
    }

    .unit_text {
        width: 40px;
        margin-left: 5px;
    }

    .unit {
        margin-left: 5px;
    }

    .btn_delete {
        margin-left: 5px;
    }
</style>