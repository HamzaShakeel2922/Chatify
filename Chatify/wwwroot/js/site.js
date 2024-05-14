
const tl = gsap.timeline();
tl.from("#mainImage",{
    duration: 1,
    opacity:0,
    y: 40,
    ease: "power1.inOut",  }).from("#heroHeading",{
    x:1000,
    duration:1,
    opacity:0,
    fontSize:"10px",
  }).from("#heroSubtitle",{
    x:-1000,
    duration:0.75,
    opacity:0,
  }).from('.card',{
        opacity:0,
        scale:0.5,
        stagger: 0.1
    })