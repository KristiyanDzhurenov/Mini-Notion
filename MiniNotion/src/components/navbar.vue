<template>
    <header width="100%" height="60px" class="main-hdr">
        <div width="100%" height="100%" class="hdr-main-div flex justify-between items-center w-full h-full px-4">
        
                <div class="hdr-div">
                <button class="hdr-btn" @click="$router.push('/')">MiniNotion</button>
                </div>


            <div class="hdr-div"></div>
            <div class="hdr-div flex gap-2">
                <RouterLink to ="/login"></RouterLink>
                    <button class="hdr-btn" @click="$router.push('/login')">Login</button>
                <RouterLink to="/register"></RouterLink>
                    <button class="hdr-btn" @click="$router.push('/register') ">Register</button>
            <div width="fit-content" height="100%" class="hdr-div"></div>
            <div width="fit-content" height="100%" class="hdr-div"></div>
            </div>
        </div>
    </header>
</template>

<style scoped>
.main-hdr {
    width: 100%;
    height: 60px;
    
}

.hdr-div {
    width: fit-content;
    height: 100%;
}

.hdr-main-div {
    width: 100%;
    height: 100%;
    display: flex;
    justify-content: space-between;
}

.hdr-btn {
    color: black;
    background-color: white;
}
</style>