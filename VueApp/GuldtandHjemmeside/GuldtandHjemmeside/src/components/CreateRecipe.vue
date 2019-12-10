<template>
    <div class="body">
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
            <button @click="addRow1">Tilf&#248;j beskrivelse</button>
            <br />
            <br />


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
            <button @click="addCategory">Tilf&#248;j ny ingrediens</button>
            <ul>
                <li v-for="(inputIng, indexIng) in inputsIng" v-bind:key="inputIng">

                    <input type="text" placeholder="..." v-model="inputIng.one" />

                    <input class="unit_text" type="text" v-model="inputIng.two" />
                    <select class="units" v-bind="unit" v-model="inputIng.three" id="unit_id">
                        <option value="g">g</option>
                        <option value="kg">kg</option>
                        <option value="ml">ml</option>
                        <option value="dl">dl</option>
                        <option value="l">l</option>
                        <option value="tsk">tsk</option>
                        <option value="spsk">spsk</option>
                        <option value="knsp">knsp</option>
                        <option value="stk">stk</option>
                        <option value="ds">ds</option>
                    </select>
                    <button class="btn_delete" @click="deleteRowIng(indexIng)">Slet</button>
                </li>
            </ul>
            <br style="clear:both" />
            <h2>
                Tilf&oslash;j billede
            </h2>
            <input type="text" placeholder="Indtast link til billede" v-model="imgUrl" />
        </div>
        <br style="clear:both" />

        <button class="test_btn" @click="created">Opret opskrift</button>
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
                inputsIng: [],
                category: [],
                info: null,
                recipeName: null,
                timeValue: null,
                ingridiens: null,
                imgUrl: null,
                unit: "",
                selected: "",
                i: 0,
                m: 0,
                descriptionString: "",
                ingridientNameString: "",
                ingridientAmountString: "",
                ingridientUnitString: "",
            }
        },
        methods: {
            addCategory() {
                this.m++;
                this.inputsIng.push({
                    one: null,
                    two: null,
                    three: null,
                })
            },
            addRow1() {
                if (this.inputs1.length < 10000) {
                    this.i++;
                    this.inputs1.push({
                        one: null,
                    })
                }
            },
            deleteRow1(index1) {
                this.i--;
                this.inputs1.splice(index1, 1)
            },
            deleteRowIng(indexIng) {
                this.m--;
                this.inputsIng.splice(indexIng, 1)
            },
            nameIngridients() {
                var k = 0;
                this.ingridientNameString = "";
                for (k = 0; k < this.m; k++) {
                    this.ingridientNameString += this.inputsIng[k].one + ";";
                }
                return this.ingridientNameString;
            },
            amountIngridients() {
                var k = 0;
                this.ingridientAmountString = "";
                for (k = 0; k < this.m; k++) {
                    this.ingridientAmountString += this.inputsIng[k].two + ";";
                }
                return this.ingridientAmountString;
            },
            unitIngridients() {
                var k = 0;
                this.ingridientUnitString = "";
                for (k = 0; k < this.m; k++) {
                    this.ingridientUnitString += this.inputsIng[k].three + ";";
                }
                return this.ingridientUnitString;
            },
            description() {
                var j = 0;
                this.descriptionString = "";
                for (j = 0; j < this.i; j++) {
                    this.descriptionString += this.inputs1[j].one + ";";
                }
                return this.descriptionString;
            },
            created() {
                this.$http.get('https://nyguldtand.azurewebsites.net/Recipe/recipeCreate?name=' + this.recipeName +
                    '&prepareTime=' + this.timeValue +
                    '&description=' + this.description() +
                    '&ingridientName=' + this.nameIngridients() +
                    '&ingridientAmount=' + this.amountIngridients() +
                    '&ingridientUnit=' + this.unitIngridients() +
                    '&imgUrl=' + this.imgUrl, {
                    headers: {
                        'Access-Control-Allow-Origin': '*',
                    },
                }).then(response => (this.info = response.data))
            }
        }
    };
</script>

<style scoped>

    /*.bodyCreateRecipe {
        width: 100%;
        max-width: 65%;
        margin: auto;
    }*/

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