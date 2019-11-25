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
            <input style="height: 28px; width: 250px;" type="text" v-model="recipeName" placeholder="Indtast navn" required>
        </div>

        <h2>
            V&#230;lg forberedelses tid
        </h2>


        <div class="prepareTime">
            <select v-model='timeValue' id="time">
                <option value="0">Forberedelse tid</option>
                <option value="15">15 min</option>
                <option value="30">30 min</option>
                <option value="45">45 min</option>
                <option value="60">1 time</option>
                <option value="75">1 time 15 min</option>
                <option value="90">1 time 30 min</option>
                <option value="105">1 time 45 min</option>
                <option value="120">2 timer</option>
                <option value="150">2 timer 30 min</option>
                <option value="180">3 timer</option>
            </select>
        </div>
        <h2>
            Skriv fremgangsm&#229;de:
        </h2>


        <div class="rows1">
            <!--addRow1-->
            <button @click="addRow1">Tilf&#248;j nyt over punkt</button>
            <br />
            <br />
          

            <ul>
                <li v-for="(input1, index1) in inputs1" v-bind:key="input1">

                    <input type="text" placeholder="..." v-model="input1.one" />
                    <button class="btn_delete" @click="deleteRow1(index1)">Slet</button>
                    <br />
                    <br />
                    
                    <button @click="addRow2">Tilf&#248;j nyt under punkt</button>

                    <ul>
                        <br />
                        <li v-for="(input2, index2) in inputs2" v-bind:key="input2">
                            <input type="text" placeholder="..." v-model="input2.one" />
                            <button class="btn_delete" @click="deleteRow2(index2)">Slet</button>
                        </li>
                        <br />

                    </ul>
                </li>
            </ul>
        </div>
        <h2>
            Skriv ingredienser: 
        </h2>
        <div class="rows2">
            <button @click="addCategory">Tilf&#248;j ny ingrediens</button>
            <ul>
                <li v-for="(inputIng, indexIng) in inputsIng" v-bind:key="inputIng">

                    <select v-model='selected' id='category' style="margin: 10px">
                        <option v-bind:key="kategoriElement" v-for="kategoriElement in inputIng.one">{{kategoriElement}}</option>
                    </select>

                    <input class="unit_text" type="text" v-model="inputIng.two" />
                        <select class="units" v-bind="unit" id="unit_id">
                            <option value="g">g</option>
                            <option value="kg">kg</option>
                            <option value="ml">ml</option>
                            <option value="dl">dl</option>
                            <option value="l">l</option>
                            <option value="tsk">tsk</option>
                            <option value="spsk">spsk</option>
                            <option value="knsp">knsp</option>
                        </select>
                    <button class="btn_delete" @click="deleteRowIng(indexIng)">Slet</button>
                </li>
            </ul>
        </div>

        <button class="test_btn" @click="created">Test</button>

        <br style="clear:both" />
        <span v-html="info">{{info}}</span>

    </div>
</template>

<script>

    export default {
        name: 'CreateRecepie',
        data: function () {
            return {
                inputs1: [],
                inputs2: [],
                inputsIng: [],
                inputs4: [],
                category: "",
                info: null,
                recipeName: null,
                timeValue: null,
                ingridiens: null,
                unit: "",
                selected: ""
            }
        },
        methods: {
            addCategory() {
                this.$http.get('https://localhost:44324/kategori/getAllCategories', {
                    headers: {
                        'Access-Control-Allow-Origin': '*',
                    },
                }).then(response => (
                    this.inputsIng.push({
                        one: response.data
                    })))
            },
            addRow1() {
                this.inputs1.push({
                    one: ''
                })
            },
            addRow2() {
                this.inputs2.push({
                    one: ''
                })
            },
            deleteRow1(index1) {
                this.inputs1.splice(index1, 1)
            },
            deleteRow2(index2) {
                this.inputs2.splice(index2, 1)
            },
            deleteRowIng(indexIng) {
                this.inputsIng.splice(indexIng, 1)
            },
            created() {
                this.$http.get('https://localhost:44324/Home/recepieCreateTest?name=' + this.recipeName + '&prepareTime=' + this.timeValue + '&unit=' + this.unit, {
                    headers: {
                        'Access-Control-Allow-Origin': '*',
                    },
                }).then(response => (this.info = response.data))
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

    .units {
        margin-left: 5px;
    }

    .btn_delete {
        margin-left: 5px;
    }
</style>